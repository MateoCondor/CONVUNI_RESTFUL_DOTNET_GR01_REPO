using WS_CONVUNI_REST_DOTNET_GR01.Enums;
using WS_CONVUNI_REST_DOTNET_GR01.Interfaces;

namespace WS_CONVUNI_REST_DOTNET_GR01.Models;

public class TemperatureConverter : IUnitConverter<TemperatureUnit>
{
    private const double _absoluteZeroCelsius = -273.15;

    public double Convert(TemperatureUnit from, TemperatureUnit to, double value)
    {
        double celsius = from switch
        {
            TemperatureUnit.Celsius => value,
            TemperatureUnit.Farenheit => (value - 32) * 5 / 9,
            TemperatureUnit.Kelvin => value - 273.15,
            TemperatureUnit.Rankine => (value - 491.67) * 5 / 9,
            TemperatureUnit.Reaumur => value * 1.25,
            _ => throw new ArgumentException("Unidad de origen no soportada")
        };

        if (celsius < _absoluteZeroCelsius)
        {
            throw new ArgumentOutOfRangeException(nameof(value),
                $"La temperatura proporcionada ({value} {from}) está por debajo del cero absoluto.");
        }

        return to switch
        {
            TemperatureUnit.Celsius => celsius,
            TemperatureUnit.Farenheit => (celsius * 9 / 5) + 32,
            TemperatureUnit.Kelvin => celsius + 273.15,
            TemperatureUnit.Rankine => (celsius + 273.15) * 9 / 5,
            TemperatureUnit.Reaumur => celsius * 0.8,
            _ => throw new ArgumentException("Unidad de destino no soportada")
        };
    }
}
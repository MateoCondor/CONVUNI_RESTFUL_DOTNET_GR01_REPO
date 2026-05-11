using WS_CONVUNI_REST_DOTNET_GR01.Interfaces;
using WS_CONVUNI_REST_DOTNET_GR01.Enums;

namespace WS_CONVUNI_REST_DOTNET_GR01.Models;

public class LengthConverter : IUnitConverter<LengthUnit>
{
    private static readonly Dictionary<LengthUnit, double> Factors = new()
    {
        [LengthUnit.Millimeters] = 0.001,
        [LengthUnit.Centimeters] = 0.01,
        [LengthUnit.Meters] = 1.0,
        [LengthUnit.Kilometers] = 1000.0,
        [LengthUnit.Feet] = 0.3048,
        [LengthUnit.Inches] = 0.0254,
        [LengthUnit.Yards] = 0.9144,
        [LengthUnit.Miles] = 1609.344,
    };

    public double Convert(LengthUnit from, LengthUnit to, double value)
    {
        if (value < 0) throw new ArgumentException("El valor debe ser 0 o positivo");

        if (!Factors.TryGetValue(from, out double baseFactor) || !Factors.TryGetValue(to, out double destinationFactor))
            throw new ArgumentException("Unidad no soportada.");

        return value * baseFactor / destinationFactor;
    }
}
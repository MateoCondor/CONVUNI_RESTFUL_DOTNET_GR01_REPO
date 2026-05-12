using WS_CONVUNI_RESTFUL_DOTNET_GR01.Enums;
using WS_CONVUNI_RESTFUL_DOTNET_GR01.Interfaces;

namespace WS_CONVUNI_RESTFUL_DOTNET_GR01.Models;

public class MassConverter : IUnitConverter<MassUnit>
{
    private static readonly Dictionary<MassUnit, double> Factors = new()
    {
        [MassUnit.Milligrams] = 0.001,
        [MassUnit.Grams] = 1.0,
        [MassUnit.Kilograms] = 1000.0,
        [MassUnit.Pounds] = 453.592,
        [MassUnit.Ounces] = 28.3495,
        [MassUnit.Tons] = 1000000.0
    };

    public double Convert(MassUnit from, MassUnit to, double value)
    {
        if (value < 0) throw new ArgumentException("El valor debe ser 0 o positivo");

        if (!Factors.TryGetValue(from, out double baseFactor) || !Factors.TryGetValue(to, out double destinationFactor))
            throw new ArgumentException("Unidad no soportada.");

        return value * baseFactor / destinationFactor;
    }
}
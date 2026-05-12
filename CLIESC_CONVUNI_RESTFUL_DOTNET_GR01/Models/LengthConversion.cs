using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

public class LengthConversion
{
    public LengthUnit From { get; set; }
    public LengthUnit To { get; set; }
    public double Value { get; set; }
}
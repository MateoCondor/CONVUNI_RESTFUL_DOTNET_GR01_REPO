using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

public class MassConversion
{
    public MassUnit From { get; set; }
    public MassUnit To { get; set; }
    public double Value { get; set; }
}
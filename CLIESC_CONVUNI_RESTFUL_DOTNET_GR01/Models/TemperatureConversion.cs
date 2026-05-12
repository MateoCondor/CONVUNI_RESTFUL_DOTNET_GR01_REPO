using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

public class TemperatureConversion
{
    public TemperatureUnit From { get; set; }
    public TemperatureUnit To { get; set; }
    public double Value { get; set; }
}
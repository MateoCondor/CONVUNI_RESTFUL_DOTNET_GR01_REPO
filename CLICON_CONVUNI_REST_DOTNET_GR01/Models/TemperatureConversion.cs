using CLICON_CONVUNI_REST_DOTNET_GR01.Enums;

namespace CLICON_CONVUNI_REST_DOTNET_GR01.Models;

public class TemperatureConversion
{
    public TemperatureUnit From { get; set; }
    public TemperatureUnit To { get; set; }
    public double Value { get; set; }
}
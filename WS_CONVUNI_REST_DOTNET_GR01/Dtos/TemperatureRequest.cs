using System.Runtime.Serialization;
using WS_CONVUNI_REST_DOTNET_GR01.Enums;

namespace WS_CONVUNI_REST_DOTNET_GR01.Dtos;

public class TemperatureRequest
{
    public required TemperatureUnit From { get; set; }
    public required TemperatureUnit To { get; set; }
    public required double Value { get; set; }
}
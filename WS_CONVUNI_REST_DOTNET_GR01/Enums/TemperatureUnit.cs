using System.Runtime.Serialization;

namespace WS_CONVUNI_REST_DOTNET_GR01.Enums;

public enum TemperatureUnit
{
    [EnumMember(Value = "C")] Celsius,
    [EnumMember(Value = "F")] Farenheit,
    [EnumMember(Value = "K")] Kelvin,
    [EnumMember(Value = "Ra")] Rankine,
    [EnumMember(Value = "Re")] Reaumur,
}
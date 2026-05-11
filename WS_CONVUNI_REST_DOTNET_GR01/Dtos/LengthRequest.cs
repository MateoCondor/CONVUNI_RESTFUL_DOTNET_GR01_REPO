using WS_CONVUNI_REST_DOTNET_GR01.Enums;

namespace WS_CONVUNI_REST_DOTNET_GR01.Dtos;

public class LengthRequest
{
    public required LengthUnit From { get; set; }
    public required LengthUnit To { get; set; }
    public required double Value { get; set; }
}
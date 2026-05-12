using System.Runtime.Serialization;
using WS_CONVUNI_RESTFUL_DOTNET_GR01.Enums;

namespace WS_CONVUNI_RESTFUL_DOTNET_GR01.Dtos;

public class MassRequest
{
    public required MassUnit From { get; set; }
    public required MassUnit To { get; set; }
    public required double Value { get; set; }
}
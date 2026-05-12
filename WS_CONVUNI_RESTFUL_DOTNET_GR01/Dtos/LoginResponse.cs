using System.Runtime.Serialization;

namespace WS_CONVUNI_RESTFUL_DOTNET_GR01.Dtos;

public class LoginResponse
{
    public bool IsAuth { get; set; }
    public required string Message { get; set; }
}
using System.Runtime.Serialization;

namespace WS_CONVUNI_REST_DOTNET_GR01.Dtos;

public class LoginRequest
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
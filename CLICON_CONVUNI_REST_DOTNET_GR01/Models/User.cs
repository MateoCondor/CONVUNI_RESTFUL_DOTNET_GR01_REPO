namespace CLICON_CONVUNI_REST_DOTNET_GR01.Models;

public class User
{
    public required string Username { get; set; }
    public Boolean IsAuth { get; set; } = false;
}
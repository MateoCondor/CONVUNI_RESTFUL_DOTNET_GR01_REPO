using System.ServiceModel;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Models;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.WebClients.Models;
using Microsoft.Kiota.Abstractions;

namespace CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Services;

public class AuthService(UnitConversionClient _client)
{
    public async Task<User> Login(string username, string password)
    {
        try
        {
            var dto = new LoginRequest()
            {
                Password = password,
                Username = username
            };

            var response = await _client.Api.Auth.Login.PostAsync(dto);

            if (response?.IsAuth == false)
                throw new ArgumentException(response.Message);

            return new User()
            {
                Username = username,
                IsAuth = response?.IsAuth ?? true
            };
        }
        catch (ApiException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Message}");
        }
        catch (HttpRequestException)
        {
            throw new Exception("Error de conexión: No se pudo alcanzar el servidor.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }
}
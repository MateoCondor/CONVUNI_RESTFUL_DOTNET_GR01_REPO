using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients.Models;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;
using Microsoft.Kiota.Abstractions;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Services;

public class AuthService
{
    private readonly UnitConversionClient _client;

    public AuthService(UnitConversionClient client)
    {
        _client = client;
    }

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
                IsAuth = response?.IsAuth ?? false
            };
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (ApiException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Message}");
        }
        catch (HttpRequestException)
        {
            throw new Exception("No se pudo establecer comunicación con el servicio SOAP. Verifique su conexión.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }
}
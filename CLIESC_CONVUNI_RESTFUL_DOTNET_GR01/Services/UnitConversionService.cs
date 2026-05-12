using System.ServiceModel;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;
using Microsoft.Kiota.Abstractions;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients.Models;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Services;

public class UnitConversionService
{
    private readonly UnitConversionClient _client;

    public UnitConversionService(UnitConversionClient client)
    {
        _client = client;
    }

    public async Task<UnitConversionResult> ConvertMass(MassConversion conversion)
    {
        try
        {
            var dto = new MassRequest()
            {
                From = (int)conversion.From,
                To = (int)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.Api.UnitConversion.Mass.PostAsync(dto);
            return new UnitConversionResult()
            {
                Message = response?.Message ?? "",
                Result = response!.Result!.Value
            };
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

    public async Task<UnitConversionResult> ConvertLength(LengthConversion conversion)
    {
        try
        {
            var dto = new LengthRequest()
            {
                From = (int)conversion.From,
                To = (int)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.Api.UnitConversion.Length.PostAsync(dto);
            return new UnitConversionResult()
            {
                Message = response?.Message ?? "",
                Result = response!.Result!.Value
            };
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

    public async Task<UnitConversionResult> ConvertTemperature(TemperatureConversion conversion)
    {
        try
        {
            var dto = new TemperatureRequest()
            {
                From = (int)conversion.From,
                To = (int)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.Api.UnitConversion.Temperature.PostAsync(dto);
            return new UnitConversionResult()
            {
                Message = response?.Message ?? "",
                Result = response!.Result!.Value
            };
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
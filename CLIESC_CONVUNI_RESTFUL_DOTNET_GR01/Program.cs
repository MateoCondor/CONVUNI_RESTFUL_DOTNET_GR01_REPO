using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Controllers;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Services;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var provider = new AnonymousAuthenticationProvider();
        var adapter = new HttpClientRequestAdapter(provider)
        {
            BaseUrl = "http://localhost:5259"
        };
        var client = new UnitConversionClient(adapter);

        var authService = new AuthService(client);
        var loginView = new LoginView();
        var authController = new AuthController(loginView, authService, client);

        Application.Run(loginView);
    }
}
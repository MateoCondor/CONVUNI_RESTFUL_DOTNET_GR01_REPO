using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Services;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Views;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Controllers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using CLICON_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;

var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider)
{
    BaseUrl = "http://localhost:5259"
};
var client = new UnitConversionClient(adapter);

var authService = new AuthService(client);
var loginView = new LoginView();
var authController = new AuthController(authService, loginView);

var user = await authController.RunLogin();

if (user.IsAuth)
{
    var unitConversionService = new UnitConversionService(client);
    var unitConversionView = new UnitConversionView();
    var unitConversionController = new UnitConversionController(unitConversionService, unitConversionView);

    await unitConversionController.Run();
}

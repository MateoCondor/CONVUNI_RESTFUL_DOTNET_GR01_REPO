using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Services;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.WebClients;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Controllers;

public class AuthController
{
    public readonly ILoginView _view;
    public readonly AuthService _service;
    public readonly UnitConversionClient _client;

    public AuthController(ILoginView view, AuthService service, UnitConversionClient client)
    {
        _view = view;
        _service = service;
        _client = client;
        _view.SubmitForm += Login;
    }

    private async void Login(object? sender, EventArgs e)
    {
        try
        {
            string username = _view.Username;
            string password = _view.Password;

            var user = await _service.Login(username, password);
            if (!user.IsAuth)
            {
                _view.ShowErrorMessage("Usuario o contraseña incorrectos");
                return;
            }

            var unitConversionService = new UnitConversionService(_client);

            IUnitConversionView unitConversionView = new UnitConversionView();
            unitConversionView.Logout += (sender, e) =>
            {
                _view.Show();
                unitConversionView.Hide();
            };

            var unitConversionController = new UnitConversionController(unitConversionView, unitConversionService);

            unitConversionView.Show();
            _view.Hide();
        }
        catch (Exception exception)
        {
            _view.ShowErrorMessage(exception.Message);
        }
    }
}
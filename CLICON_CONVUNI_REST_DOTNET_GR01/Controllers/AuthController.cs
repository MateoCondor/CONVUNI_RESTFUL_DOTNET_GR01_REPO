using CLICON_CONVUNI_REST_DOTNET_GR01.Models;
using CLICON_CONVUNI_REST_DOTNET_GR01.Services;
using CLICON_CONVUNI_REST_DOTNET_GR01.Views;

namespace CLICON_CONVUNI_REST_DOTNET_GR01.Controllers;

public class AuthController
{
    private readonly AuthService _service;
    private readonly LoginView _view;

    public AuthController(AuthService authService, LoginView view)
    {
        _service = authService;
        _view = view;
    }

    public async Task<User> RunLogin()
    {
        var credentials = _view.ShowLogin();

        var user = new User()
        {
            Username = "John Doe"
        };

        try
        {
            user = await _service.Login(credentials.username, credentials.password);

            if (user.IsAuth)
            {
                _view.ShowWelcome(user.Username);
            }
        }
        catch (Exception ex)
        {
            _view.ShowError(ex.Message);
        }

        return user;
    }
}
namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views;

public interface ILoginView
{
    string Username { get; }
    string Password { get; }
    event EventHandler SubmitForm;
    void ShowErrorMessage(string message);
    void ResetForm();
    void Show();
    void Hide();
}
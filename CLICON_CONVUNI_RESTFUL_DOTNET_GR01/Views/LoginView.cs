namespace CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Views;

public class LoginView
{
    public (string username, string password) ShowLogin()
    {
        Console.Clear();
        Console.WriteLine("=== INICIO DE SESIÓN ===");
        Console.Write("Usuario: ");
        string user = Console.ReadLine() ?? "";

        Console.Write("Contraseña: ");
        string pass = ReadPassword();

        return (user, pass);
    }

    public void ShowWelcome(string username)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n[SUCCESS] ¡Bienvenido, {username}!");
        Console.ResetColor();
    }

    public void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n[ERROR] {message}");
        Console.ResetColor();
    }

    private string ReadPassword()
    {
        string pass = "";
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                pass += key.KeyChar;
                Console.Write("*");
            }
        } while (key.Key != ConsoleKey.Enter);
        Console.WriteLine();
        return pass;
    }
}
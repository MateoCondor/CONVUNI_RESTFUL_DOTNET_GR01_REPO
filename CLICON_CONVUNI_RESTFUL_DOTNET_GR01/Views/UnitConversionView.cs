namespace CLICON_CONVUNI_RESTFUL_DOTNET_GR01.Views;

public class UnitConversionView
{
    public int ShowMainMenu()
    {
        Console.WriteLine("\n=== MENÚ DE CONVERSIONES ===");
        Console.WriteLine("1. Masa");
        Console.WriteLine("2. Longitud");
        Console.WriteLine("3. Temperatura");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");
        int.TryParse(Console.ReadLine(), out int result);
        return result;
    }

    public T SelectUnit<T>(string label, Dictionary<T, string>? optionsLabels = null) where T : struct, Enum
    {
        Console.WriteLine($"\nSeleccione unidad de {label}:");
        var values = Enum.GetValues<T>();
        for (int i = 0; i < values.Length; i++)
        {
            string optionLabel = optionsLabels != null ? optionsLabels.GetValueOrDefault(values[i], values[i].ToString()) : values[i].ToString();
            Console.WriteLine($"{i + 1}. {optionLabel}");
        }

        Console.Write("Opción: ");
        int.TryParse(Console.ReadLine(), out int choice);
        return values[Math.Clamp(choice - 1, 0, values.Length - 1)];
    }

    public double GetValue()
    {
        Console.Write("Ingrese el valor a convertir: ");
        double.TryParse(Console.ReadLine(), out double val);
        return val;
    }

    public void ShowResult(string message, double result)
    {
        Console.WriteLine("\n============================");
        Console.WriteLine($"Resultado: {result}");
        Console.WriteLine($"Estado: {message}");
        Console.WriteLine("============================");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    public void ShowErrorMessage(string message)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n[ !!! ERROR DE CONEXIÓN !!! ]");
        Console.ResetColor();
        Console.WriteLine($"Detalle: {message}");
        Console.WriteLine("Presione una tecla para volver al menú...");
        Console.ReadKey();
    }
}
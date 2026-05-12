namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

public class ComboItem<T> where T : struct, Enum
{
    public T Value { get; set; }
    public string Label { get; set; }

    public ComboItem(T value, string label)
    {
        Value = value;
        Label = label;
    }
}
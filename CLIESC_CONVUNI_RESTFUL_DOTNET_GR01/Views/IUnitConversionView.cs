using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views;

public interface IUnitConversionView
{
    UnitConversionType UnitConversionTypeSelected { get; }
    Enum ConversionUnitSource { get; }
    Enum ConversionUnitDestination { get; }
    string ConversionUnitValue { get; }
    event EventHandler Logout;
    event EventHandler UnitConversionTypeChanged;
    event EventHandler SubmitForm;
    void LoadUnitConversionTypes(List<ComboItem<UnitConversionType>> options);
    void LoadConversionUnits<T>(List<ComboItem<T>> options) where T : struct, Enum;
    void ShowErrorMessage(string message);
    void ShowResult(double result);
    void ResetForm();
    void Show();
    void Hide();
}
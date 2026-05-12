using System.ComponentModel;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Services;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Controllers;

public class UnitConversionController
{
    private readonly IUnitConversionView _view;
    private readonly UnitConversionService _service;
    private readonly List<ComboItem<UnitConversionType>> _unitConversionTypeOptions =
    [
        new ComboItem<UnitConversionType>(UnitConversionType.Length, "Longitud"),
        new ComboItem<UnitConversionType>(UnitConversionType.Mass, "Masa"),
        new ComboItem<UnitConversionType>(UnitConversionType.Temperature, "Temperatura"),
    ];

    private readonly List<ComboItem<MassUnit>> _massUnitOptions =
    [
        new ComboItem<MassUnit>(MassUnit.Grams, "Gramos"),
        new ComboItem<MassUnit>(MassUnit.Kilograms, "Kilogramos"),
        new ComboItem<MassUnit>(MassUnit.Milligrams, "Miligramos"),
        new ComboItem<MassUnit>(MassUnit.Ounces, "Onzas"),
        new ComboItem<MassUnit>(MassUnit.Pounds, "Libras"),
        new ComboItem<MassUnit>(MassUnit.Tons, "Toneladas"),
    ];

    private readonly List<ComboItem<LengthUnit>> _lengthUnitOptions =
    [
        new ComboItem<LengthUnit>(LengthUnit.Centimeters, "Centímetros"),
        new ComboItem<LengthUnit>(LengthUnit.Feet, "Pies"),
        new ComboItem<LengthUnit>(LengthUnit.Inches, "Pulgadas"),
        new ComboItem<LengthUnit>(LengthUnit.Kilometers, "Kilómetros"),
        new ComboItem<LengthUnit>(LengthUnit.Meters, "Metros"),
        new ComboItem<LengthUnit>(LengthUnit.Miles, "Millas"),
        new ComboItem<LengthUnit>(LengthUnit.Millimeters, "Milímetros"),
        new ComboItem<LengthUnit>(LengthUnit.Yards, "Yardas"),
    ];

    private readonly List<ComboItem<TemperatureUnit>> _temperatureUnitOptions =
    [
        new ComboItem<TemperatureUnit>(TemperatureUnit.Celsius, "Celsius"),
        new ComboItem<TemperatureUnit>(TemperatureUnit.Farenheit, "Farenheit"),
        new ComboItem<TemperatureUnit>(TemperatureUnit.Kelvin, "Kelvin"),
        new ComboItem<TemperatureUnit>(TemperatureUnit.Rankine, "Rankine"),
        new ComboItem<TemperatureUnit>(TemperatureUnit.Reaumur, "Reaumur"),
    ];

    public UnitConversionController(IUnitConversionView view, UnitConversionService service)
    {
        _view = view;
        _service = service;
        _view.UnitConversionTypeChanged += LoadConversionUnits;
        _view.SubmitForm += Convert;
        InitView();
    }

    private void InitView()
    {
        _view.LoadUnitConversionTypes(_unitConversionTypeOptions);
    }

    private void LoadConversionUnits(object? sender, EventArgs e)
    {
        switch (_view.UnitConversionTypeSelected)
        {
            case UnitConversionType.Length:
                _view.LoadConversionUnits(_lengthUnitOptions);
                break;

            case UnitConversionType.Mass:
                _view.LoadConversionUnits(_massUnitOptions);
                break;

            case UnitConversionType.Temperature:
                _view.LoadConversionUnits(_temperatureUnitOptions);
                break;
        }
    }

    private async void Convert(object? sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(_view.ConversionUnitValue, out int value))
            {
                _view.ShowErrorMessage("El valor de conversión tiene que ser un número entero.");
                return;
            }

            var response = _view.UnitConversionTypeSelected switch
            {
                UnitConversionType.Mass => await ConvertMass(new MassConversion()
                {
                    From = (MassUnit)_view.ConversionUnitSource,
                    To = (MassUnit)_view.ConversionUnitDestination,
                    Value = value,
                }),
                UnitConversionType.Length => await ConvertLength(new LengthConversion()
                {
                    From = (LengthUnit)_view.ConversionUnitSource,
                    To = (LengthUnit)_view.ConversionUnitDestination,
                    Value = value,
                }),
                UnitConversionType.Temperature => await ConvertTemperature(new TemperatureConversion()
                {
                    From = (TemperatureUnit)_view.ConversionUnitSource,
                    To = (TemperatureUnit)_view.ConversionUnitDestination,
                    Value = value,
                }),
                _ => throw new InvalidEnumArgumentException("El tipo de unidad de conversión no es válida")
            };

            _view.ShowResult(response.Result);
        }
        catch (Exception exception)
        {
            _view.ShowErrorMessage(exception.Message);
        }
    }

    private async Task<UnitConversionResult> ConvertMass(MassConversion dto)
    {
        return await _service.ConvertMass(dto);
    }

    private async Task<UnitConversionResult> ConvertLength(LengthConversion dto)
    {
        return await _service.ConvertLength(dto);
    }

    private async Task<UnitConversionResult> ConvertTemperature(TemperatureConversion dto)
    {
        return await _service.ConvertTemperature(dto);
    }
}
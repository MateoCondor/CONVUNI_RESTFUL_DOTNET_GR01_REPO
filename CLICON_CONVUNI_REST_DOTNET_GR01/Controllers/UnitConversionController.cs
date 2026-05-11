using CLICON_CONVUNI_REST_DOTNET_GR01.Services;
using CLICON_CONVUNI_REST_DOTNET_GR01.Views;
using CLICON_CONVUNI_REST_DOTNET_GR01.Models;
using CLICON_CONVUNI_REST_DOTNET_GR01.Enums;

namespace CLICON_CONVUNI_REST_DOTNET_GR01.Controllers;

public class UnitConversionController
{
    private readonly UnitConversionService _service;
    private readonly UnitConversionView _view;

    public UnitConversionController(UnitConversionService service, UnitConversionView view)
    {
        _service = service;
        _view = view;
    }

    public async Task Run()
    {
        bool exit = false;
        while (!exit)
        {
            int option = _view.ShowMainMenu();
            switch (option)
            {
                case 1: await HandleMass(); break;
                case 2: await HandleLength(); break;
                case 3: await HandleTemperature(); break;
                case 4: exit = true; break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
    }

    private async Task HandleTemperature()
    {
        try
        {
            var from = _view.SelectUnit<TemperatureUnit>("ORIGEN");
            var to = _view.SelectUnit<TemperatureUnit>("DESTINO");
            var value = _view.GetValue();

            var model = new TemperatureConversion { From = from, To = to, Value = value };

            var result = await _service.ConvertTemperature(model);

            _view.ShowResult(result.Message, result.Result);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task HandleMass()
    {
        try
        {
            var optionsLabels = new Dictionary<MassUnit, string>()
            {
                [MassUnit.Grams] = "Gramos",
                [MassUnit.Kilograms] = "Kilogramos",
                [MassUnit.Milligrams] = "Miligramos",
                [MassUnit.Ounces] = "Onzas",
                [MassUnit.Pounds] = "Libras",
                [MassUnit.Tons] = "Toneladas",
            };

            var from = _view.SelectUnit("ORIGEN", optionsLabels);
            var to = _view.SelectUnit("DESTINO", optionsLabels);
            var value = _view.GetValue();

            var model = new MassConversion { From = from, To = to, Value = value };

            var result = await _service.ConvertMass(model);

            _view.ShowResult(result.Message, result.Result);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task HandleLength()
    {
        try
        {
            var optionsLabels = new Dictionary<LengthUnit, string>()
            {
                [LengthUnit.Centimeters] = "Centímetros",
                [LengthUnit.Feet] = "Pies",
                [LengthUnit.Inches] = "Pulgadas",
                [LengthUnit.Kilometers] = "Kilómetros",
                [LengthUnit.Meters] = "Metros",
                [LengthUnit.Miles] = "Millas",
                [LengthUnit.Millimeters] = "Milímetros",
                [LengthUnit.Yards] = "Yardas",
            };

            var from = _view.SelectUnit("ORIGEN", optionsLabels);
            var to = _view.SelectUnit("DESTINO", optionsLabels);
            var value = _view.GetValue();

            var model = new LengthConversion { From = from, To = to, Value = value };

            var result = await _service.ConvertLength(model);

            _view.ShowResult(result.Message, result.Result);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }
}
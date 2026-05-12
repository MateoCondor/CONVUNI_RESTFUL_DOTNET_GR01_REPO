using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Enums;
using CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Models;

namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views
{
    public partial class UnitConversionView : Form, IUnitConversionView
    {
        public UnitConversionType UnitConversionTypeSelected => UnitConversionTypeSelect.SelectedItem is ComboItem<UnitConversionType> comboItem
                                                                ? comboItem.Value
                                                                : UnitConversionType.Length;
        public Enum ConversionUnitSource => ConversionUnitSourceSelect.SelectedItem is ComboItem<MassUnit> massItem ? massItem.Value
                                            : ConversionUnitSourceSelect.SelectedItem is ComboItem<LengthUnit> lengthItem ? lengthItem.Value
                                            : ConversionUnitSourceSelect.SelectedItem is ComboItem<TemperatureUnit> temperatureItem ? temperatureItem.Value
                                            : LengthUnit.Centimeters;
        public Enum ConversionUnitDestination => ConversionUnitDestinationSelect.SelectedItem is ComboItem<MassUnit> massItem ? massItem.Value : ConversionUnitDestinationSelect.SelectedItem is ComboItem<LengthUnit> lengthItem ? lengthItem.Value : ConversionUnitDestinationSelect.SelectedItem is ComboItem<TemperatureUnit> temperatureItem ? temperatureItem.Value : LengthUnit.Centimeters;
        public string ConversionUnitValue => ConversionUnitValueTextBox.Text;
        public event EventHandler Logout = delegate { };
        public event EventHandler UnitConversionTypeChanged = delegate { };
        public event EventHandler SubmitForm = delegate { };

        public UnitConversionView()
        {
            InitializeComponent();
        }

        public void UnitConversionView_FormClosed(object sender, EventArgs e)
        {
            Logout?.Invoke(this, e);
        }

        public void LoadUnitConversionTypes(List<ComboItem<UnitConversionType>> options)
        {
            UnitConversionTypeSelect.DataSource = options;
            UnitConversionTypeSelect.ValueMember = "Value";
            UnitConversionTypeSelect.DisplayMember = "Label";
        }

        private void ConversionTypeSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            UnitConversionTypeChanged?.Invoke(this, e);
        }

        private void ConversionValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (char.IsDigit(e.KeyChar)) return;

            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.')) return;

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length == 0) return;

            e.Handled = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(this, e);
        }

        public void LoadConversionUnits<T>(List<ComboItem<T>> options) where T : struct, Enum
        {
            ConversionUnitSourceSelect.DataSource = options.ToList();
            ConversionUnitSourceSelect.ValueMember = "Value";
            ConversionUnitSourceSelect.DisplayMember = "Label";

            ConversionUnitDestinationSelect.DataSource = options.ToList();
            ConversionUnitDestinationSelect.ValueMember = "Value";
            ConversionUnitDestinationSelect.DisplayMember = "Label";
        }

        public void ShowErrorMessage(string message)
        {
            ErrorTextBox.Text = message;
            ErrorTextBox.Visible = true;
        }

        public void ShowResult(double result)
        {
            ConversionUnitResultTextBox.Text = result.ToString();
        }

        public void ResetForm()
        {
            ErrorTextBox.Text = "";
            ConversionUnitResultTextBox.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ErrorTextBox.Visible = false;
            SubmitForm?.Invoke(this, e);
        }

        public new void Show()
        {
            ResetForm();
            base.Show();
        }
    }
}

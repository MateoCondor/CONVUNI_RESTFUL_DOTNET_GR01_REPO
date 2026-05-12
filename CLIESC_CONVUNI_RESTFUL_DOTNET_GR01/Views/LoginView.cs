namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Username => UsernameTextBox.Text;

        public string Password => PasswordTextBox.Text;

        public event EventHandler SubmitForm = delegate { };

        public void ShowErrorMessage(string message)
        {
            ErrorTextBox.Text = message;
            ErrorTextBox.Visible = true;
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

        public void ResetForm()
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}

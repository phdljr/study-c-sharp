using ExampleMVP.View;

namespace ExampleMVP
{
    public partial class LoginForm : Form, ILoginView
    {

        public event EventHandler LoginAttempt;
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Id => txtId.Text;

        public string Password => txtPassword.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToMainForm()
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnLoginClickHandler(object sender, EventArgs e)
        {
            LoginAttempt?.Invoke(this, EventArgs.Empty);
        }
    }
}

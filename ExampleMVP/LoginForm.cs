using ExampleMVP.Presenter;
using ExampleMVP.View;

namespace ExampleMVP
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler LoginAttempt;

        public event EventHandler SignUpNavigate;

        public string Username => txtUsername.Text;

        public string Password => txtPassword.Text;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        public void NavigateToSignUpForm()
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLoginClickHandler(object sender, EventArgs e)
        {
            LoginAttempt(this, EventArgs.Empty);
        }

        private void btnSignUpClickHandler(object sender, EventArgs e)
        {
            SignUpNavigate(this, EventArgs.Empty);
        }
    }
}

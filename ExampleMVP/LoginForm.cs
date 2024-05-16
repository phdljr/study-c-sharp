using ExampleMVP.Model;
using ExampleMVP.Presenter;
using ExampleMVP.View;

namespace ExampleMVP
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler? LoginAttempt;

        public event EventHandler? SignUpNavigate;

        public string Username => txtUsername.Text;

        public string Password => txtPassword.Text;

        private readonly LoginPresenter loginPresenter;

        public LoginForm()
        {
            InitializeComponent();
            this.loginPresenter = new LoginPresenter(this);
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
            LoginAttempt?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignUpClickHandler(object sender, EventArgs e)
        {
            SignUpNavigate?.Invoke(this, EventArgs.Empty);
        }
    }
}

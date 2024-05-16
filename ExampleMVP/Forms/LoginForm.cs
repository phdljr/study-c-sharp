using ExampleMVP.Model;
using ExampleMVP.Presenter;
using ExampleMVP.View;
using System.Diagnostics;

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
            Debug.WriteLine("로그인 폼 생성");
        }

        ~LoginForm() 
        {
            Debug.WriteLine("로그인 폼 삭제");
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToMainForm()
        {
            Program.mainForm.Show();
            this.Hide();
        }

        public void NavigateToSignUpForm()
        {
            Program.signUpForm.Show();
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

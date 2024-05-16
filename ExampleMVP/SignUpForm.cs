using ExampleMVP.Presenter;
using ExampleMVP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleMVP
{
    public partial class SignUpForm : Form, ISignUpView
    {
        public event EventHandler? SignUpAttempt;

        public event EventHandler? LoginNavigate;

        public string Username => txtUsername.Text;

        public string Password => txtPassword.Text;

        public string ConfirmPassword => txtConfirmPassword.Text;

        private readonly SignUpPresenter signUpPresenter;

        public SignUpForm()
        {
            InitializeComponent();
            this.signUpPresenter = new SignUpPresenter(this);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignUpClickHandler(object sender, EventArgs e)
        {
            SignUpAttempt?.Invoke(this, EventArgs.Empty);
        }

        private void btnNavigateLoginFormHandler(object sender, EventArgs e)
        {
            LoginNavigate?.Invoke(this, EventArgs.Empty);
        }
    }
}

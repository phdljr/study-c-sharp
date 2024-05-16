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
        public event EventHandler SignUpAttempt;

        public event EventHandler LoginNavigate;

        public string Username => txtUsername.Text;

        public string Password => txtPassword.Text;

        public string ConfirmPassword => txtConfirmPassword.Text;

        public SignUpForm()
        {
            InitializeComponent();
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

        private void btnExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUpClickHandler(object sender, EventArgs e)
        {
            SignUpAttempt(this, EventArgs.Empty);
        }

        private void btnNavigateLoginFormHandler(object sender, EventArgs e)
        {
            LoginNavigate(this, EventArgs.Empty);
        }
    }
}

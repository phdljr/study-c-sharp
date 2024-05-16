using ExampleMVP.Presenter;
using ExampleMVP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Debug.WriteLine("회원가입 폼 생성");
        }

        ~SignUpForm() 
        {
            Debug.WriteLine("회원가입 폼 삭제");
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void NavigateToLoginForm()
        {
            Program.loginForm.Show();
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

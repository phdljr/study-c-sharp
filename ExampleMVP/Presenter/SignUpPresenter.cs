using ExampleMVP.Model;
using ExampleMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.Presenter
{
    internal class SignUpPresenter
    {
        private readonly ISignUpView signUpView;
        private readonly SignUpModel signUpModel;

        public SignUpPresenter(ISignUpView signUpView)
        {
            this.signUpView = signUpView;
            this.signUpModel = new SignUpModel();
            this.signUpView.SignUpAttempt += OnSignUpAttempt;
            this.signUpView.LoginNavigate += OnLoginNavigate;
        }

        private void OnLoginNavigate(object? sender, EventArgs e)
        {
            signUpView.NavigateToLoginForm();
        }

        private void OnSignUpAttempt(object? sender, EventArgs e)
        {
            string username = signUpView.Username;
            string password = signUpView.Password;
            string confirmPassword = signUpView.ConfirmPassword;

            if(signUpModel.SignUp(username, password, confirmPassword))
            {
                signUpView.ShowMessage("회원가입 성공");
                signUpView.NavigateToLoginForm();
            }
            else
            {
                signUpView.ShowMessage("회원가입 실패");
            }
        }
    }
}

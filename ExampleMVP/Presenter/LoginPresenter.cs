using ExampleMVP.Model;
using ExampleMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.Presenter
{
    internal class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly LoginModel model;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;
            this.model = new LoginModel();
            this.view.LoginAttempt += OnLoginAttempt;
            this.view.SignUpNavigate += OnSignUpAttempt;
            view.LoginAttempt();
        }

        private void OnSignUpAttempt(object? sender, EventArgs e)
        {
            view.NavigateToSignUpForm();
        }

        private void OnLoginAttempt(object? sender, EventArgs eventArgs)
        {
            string username = view.Username;
            string password = view.Password;

            if(model.Login(username, password))
            {
                view.NavigateToMainForm();
            }
            else
            {
                view.ShowMessage("로그인 실패");
            }
        }
    }
}

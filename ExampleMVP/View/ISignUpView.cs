using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.View
{
    internal interface ISignUpView
    {
        public event EventHandler SignUpAttempt;
        public event EventHandler LoginNavigate;
        public string Username { get; }
        public string Password { get; }
        public string ConfirmPassword { get; }
        void ShowMessage(string message);
        void NavigateToLoginForm();
    }
}

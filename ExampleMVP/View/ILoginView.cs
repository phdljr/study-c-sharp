using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.View
{
    internal interface ILoginView
    {
        public event EventHandler LoginAttempt;
        public string Id { get; }
        public string Password { get; }
        void ShowMessage(string message);
        void NavigateToMainForm();
    }
}

using ExampleMVP.Model;
using ExampleMVP.Presenter;
using ExampleMVP.View;
using System.Configuration;

namespace ExampleMVP
{
    internal static class Program
    {
        public static readonly LoginForm MyLoginForm = new LoginForm();
        public static readonly SignUpForm MySignUpForm = new SignUpForm();
        public static readonly MainForm MyMainForm = new MainForm();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(MyLoginForm);
        }
    }
}
using ExampleMVP.Model;
using ExampleMVP.Presenter;
using ExampleMVP.View;
using System.Configuration;

namespace ExampleMVP
{
    internal static class Program
    {
        public static readonly LoginForm loginForm = new LoginForm();
        public static readonly SignUpForm signUpForm = new SignUpForm();
        public static readonly MainForm mainForm = new MainForm();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(loginForm);
        }
    }
}
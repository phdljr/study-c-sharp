using ExampleMVP.Model;
using ExampleMVP.Presenter;
using ExampleMVP.View;
using System.Configuration;

namespace ExampleMVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var connectionStr = ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString;

            var view = new LoginForm();
            var model = new LoginModel(connectionStr);
            var presenter = new LoginPresenter(view, model);

            var signUpView = new SignUpForm();
            var signUpModel = new SignUpModel(connectionStr);
            var signUpPresenter = new SignUpPresenter(signUpView, signUpModel);

            Application.Run(view);
        }
    }
}
using System.Configuration;
using System.Data.SqlClient;

namespace ExampleMVP.Model
{
    internal class LoginModel
    {
        private readonly string connectionString;
        public LoginModel() 
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString;
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM TB_MEMBER WHERE username = @username AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }
    }
}

﻿using ExampleMVP.CustomException;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVP.Model
{
    internal class SignUpModel
    {
        private readonly string connectionString;
        public SignUpModel()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString;
        }

        public bool SignUp(string username, string password, string confirmPassword)
        {
            validatePassword(password, confirmPassword);
            validateUsername(username);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO TB_MEMBER VALUES(@username, @password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Username", username));
                    command.Parameters.Add(new SqlParameter("@Password", password));

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        private void validatePassword(string password, string confirmPassword)
        {
            if(!password.Equals(confirmPassword))
            {
                throw new NotMatchPasswordException("비밀번호가 일치하지 않습니다.");
            }
        }

        private void validateUsername(string username)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM TB_MEMBER WHERE username = @username";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int userCount = (int)command.ExecuteScalar();
                    if(userCount > 0)
                    {
                        throw new AlreadyExistsUsernameException("이미 존재하는 아이디입니다.");
                    }
                }
            }
        }
    }
}

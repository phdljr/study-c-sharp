using System.Collections;
using System.Collections.Concurrent;
using System.Data;
using MySql.Data.MySqlClient;

namespace StudyCS
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            const string str = "Server=localhost,3306;Database=test;Uid=root;Pwd=1234;";
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO member VALUES (null, 'Tom')", conn);
                cmd.ExecuteNonQuery();

                string sql = "SELECT * FROM member";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);
            }

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["Name"]);
            }
        }
    }
}

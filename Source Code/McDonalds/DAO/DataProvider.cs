
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace McDonalds.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            try
            {
                string connectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=MCDONALDS;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch
            {
                string connectionStr = @"Data Source=.\;Initial Catalog=MCDONALDS;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            return data;
        }
        public void ExcuteNonQuery(string query)
        {

            string connectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=MCDONALDS;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Close();
            }
        }
    }
}

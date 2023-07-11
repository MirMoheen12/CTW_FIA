using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class StoredProcedureRepo : IStoredProcedure
    {
        private readonly IConfiguration configuration;

        public StoredProcedureRepo(IConfiguration configuration)
        {
            this.configuration = configuration;

        }

        public DataTable ExecuteStoredProcedure(string storedProcedure)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            using SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(storedProcedure, connection);
            command.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error executing stored procedure: " + ex.Message);
            }

            return dataTable;
        }

        public DataTable GetUserByCredentials(string username, string password)
        {
            string storedProcedure = "GetUserByCredentials";

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            using SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(storedProcedure, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                return dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine("Error executing stored procedure: " + ex.Message);
                return null;
            }

        }
    }
}

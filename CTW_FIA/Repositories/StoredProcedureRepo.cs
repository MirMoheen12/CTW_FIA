using CTW_FIA.Interface;
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
            string connectionString = "saas";
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

    }
}

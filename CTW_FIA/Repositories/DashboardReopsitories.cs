using CTW_FIA.Interface;
using CTW_FIA.Models.LocalModels;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class DashboardReopsitories : IDashboard
    {
        private readonly IConfiguration configuration;

        public DashboardReopsitories(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public GraphCount getCtwdashboard()
        {
            try
            {

                var dt = AllRecord();
                return dt;
            }
            catch (Exception)
            {

               return null;
            }
        }
        private GraphCount AllRecord()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            List<GraphDto> graphDtos=new List<GraphDto>();
            GraphCount graph = new GraphCount();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_Dashboard_web", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    // Access the first table
                    DataTable firstTable = dataSet.Tables[0];
                    if (firstTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in firstTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "provincewise";
                            dto.TotalRecord = (int)row["TotalRecord"];
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }

                    // Access the second table
                    DataTable secondTable = dataSet.Tables[1];
                    if (secondTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in secondTable.Rows)
                        {
                            // Access the values of the columns for each row

                            graph.Incidentcount = (int)row["IncidentCount"];
                            graph.Groupcount = (int)row["GroupCount"];
                            graph.Personcount = (int)row["PersonCount"];
                            graph.Explosivecount = (int)row["ExplosiveCount"];

                            // Process the data as needed
                        }
                    }
                    DataTable thirdTable = dataSet.Tables[2];
                    if (thirdTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in thirdTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "pprovince";
                            dto.TotalRecord = (int)row["TotalRecord"];
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fourTable = dataSet.Tables[3];
                    if (fourTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fourTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "Exwise";
                            dto.TotalRecord = (int)row["TotalRecord"];
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                }
            }
            graph.graphDtos = graphDtos;
            return graph;
        }
    }
}

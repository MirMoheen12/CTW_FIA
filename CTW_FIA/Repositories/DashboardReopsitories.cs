using CTW_FIA.Interface;
using CTW_FIA.Models.LocalModels;
using Microsoft.Data.SqlClient;
using NuGet.Packaging.Signing;
using System.Configuration;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class DashboardReopsitories : IDashboard
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;

        public DashboardReopsitories(IConfiguration configuration, IDatabaseRepo databaseRepo)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
        }
        public GraphCount getCtwdashboard()
        {
            try
            {

                var dt = AlldashboardRecord();
                return dt;
            }
            catch (Exception)
            {

               return null;
            }
        }

        public List<GraphDto> getCtwdashboardsGraphwise()
        {
            try
            {
                var data = GroupWisedashboardRecord();
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<GraphDto> getCtwdashboardsIncidentwise()
        {
            try
            {
                var data = getIncidnetwise();
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private GraphCount AlldashboardRecord()
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
                            dto.TotalRecord = row["TotalRecord"].ToString();
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
                            dto.TotalRecord = row["TotalRecord"].ToString();
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
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fivetable = dataSet.Tables[4];
                    if (fivetable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fivetable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "Groupwise";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                }
            }
            graph.graphDtos = graphDtos;
            return graph;
        }
        private List<GraphDto> GroupWisedashboardRecord()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            List<GraphDto> graphDtos = new List<GraphDto>();
       
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_Terroristgroup_web", connection))
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
                            dto.tablename = "FG";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }

                    
                    DataTable thirdTable = dataSet.Tables[1];
                    if (thirdTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in thirdTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "PKG";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fourTable = dataSet.Tables[2];
                    if (fourTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fourTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "TopG";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable Groupwise = dataSet.Tables[3];
                    if (Groupwise.Rows.Count > 0)
                    {
                        foreach (DataRow row in Groupwise.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "GW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable TGroupwise = dataSet.Tables[4];
                    if (TGroupwise.Rows.Count > 0)
                    {
                        foreach (DataRow row in TGroupwise.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "TGW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }

                }
            }

            return graphDtos;
        }
        private List<GraphDto> getIncidnetwise()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            List<GraphDto> graphDtos = new List<GraphDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_Incidentwisegraph_web", connection))
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
                            dto.tablename = "PW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }


                    DataTable thirdTable = dataSet.Tables[1];
                    if (thirdTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in thirdTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "T10";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fourTable = dataSet.Tables[2];
                    if (fourTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fourTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "WW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable targetwise = dataSet.Tables[3];
                    if (targetwise.Rows.Count > 0)
                    {
                        foreach (DataRow row in targetwise.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "TW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable Motiw = dataSet.Tables[4];
                    if (Motiw.Rows.Count > 0)
                    {
                        foreach (DataRow row in Motiw.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "MW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable Gw = dataSet.Tables[5];
                    if (Gw.Rows.Count > 0)
                    {
                        foreach (DataRow row in Gw.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "GW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                }
            }

            return graphDtos;
        }
        private List<GraphDto> getterroristwise()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            List<GraphDto> graphDtos = new List<GraphDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_terroristdashboard_web", connection))
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
                            dto.tablename = "TP";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }


                    DataTable thirdTable = dataSet.Tables[1];
                    if (thirdTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in thirdTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "HM";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fourTable = dataSet.Tables[2];
                    if (fourTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fourTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "AS";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable fiveTable = dataSet.Tables[3];
                    if (fiveTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in fiveTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "TMW";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable sixtable = dataSet.Tables[4];
                    if (sixtable.Rows.Count > 0)
                    {
                        foreach (DataRow row in sixtable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "TMWFor";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable UN = dataSet.Tables[5];
                    if (UN.Rows.Count > 0)
                    {
                        foreach (DataRow row in UN.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "UN";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable MWT = dataSet.Tables[6];
                    if (MWT.Rows.Count > 0)
                    {
                        foreach (DataRow row in MWT.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "MWT";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = row["Name"].ToString();
                            graphDtos.Add(dto);
                        }
                    }

                }
            }

            return graphDtos;
        }
        private List<GraphDto> getExplosivewise()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            List<GraphDto> graphDtos = new List<GraphDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_explosive_web", connection))
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
                            dto.tablename = "Exp";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }
                    DataTable SecondTable = dataSet.Tables[1];
                    if (SecondTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in SecondTable.Rows)
                        {
                            GraphDto dto = new GraphDto();
                            dto.tablename = "Sec";
                            dto.TotalRecord = row["TotalRecord"].ToString();
                            dto.Name = (string)row["Name"];
                            graphDtos.Add(dto);
                        }
                    }


                }
            }

            return graphDtos;
        }

        public List<GraphDto> getCtwdashboardsterroristtwise()
        {
            try
            {
                var data = getterroristwise();
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<GraphDto> getCtwdashboardsExplosivetwise()
        {
            try
            {
                var data = getExplosivewise();
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<GraphDto> getCtwdashboardsLeftnavigation()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "sp_leftnavigation_web", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(GraphDto));
            var list = new List<GraphDto>();
            foreach (var item in res)
            {
                list.Add((GraphDto)item);
            }
            return list;
            
        }
    }
}


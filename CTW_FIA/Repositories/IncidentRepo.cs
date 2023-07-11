using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class IncidentRepo:IIncident
    {
        private readonly IConfiguration configuration;

        public IncidentRepo(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public List<PreviewIncident> getIncidentProvincewiese(string Province)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Incident_Provinces", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@provinceName", SqlDbType.VarChar).Value = Province;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    List<PreviewIncident> result = new List<PreviewIncident>();

                    if (dataSet != null && dataSet.Tables.Count > 0)
                    {
                        DataTable dataTable = dataSet.Tables[0]; // Assuming the data is in the first table

                        foreach (DataRow row in dataTable.Rows)
                        {
                            PreviewIncident item = new PreviewIncident();

                            // Map the values from the DataRow to the properties of PreviewIncident
                            item.intid = Convert.ToInt32(row["intid"]);
                            item.SerialNo = row["SerialNo"] != DBNull.Value ? Convert.ToInt64(row["SerialNo"]) : (long?)null;
                            item.strOperationName = row["strOperationName"].ToString();
                            item.FirNo = row["FirNo"].ToString();
                            item.NumberKilled = row["NumberKilled"] != DBNull.Value ? Convert.ToInt32(row["NumberKilled"]) : (int?)null;
                            item.NumberInjured = row["NumberInjured"] != DBNull.Value ? Convert.ToInt32(row["NumberInjured"]) : (int?)null;
                            item.Inc_Date = row["Inc_Date"].ToString();
                            item.RegYear = row["RegYear"] != DBNull.Value ? Convert.ToInt32(row["RegYear"]) : (int?)null;
                            item.US = row["US"].ToString();
                            item.Country = row["Country"].ToString();
                            item.Province = row["Province"].ToString();
                            item.City = row["City"].ToString();
                            item.District = row["District"].ToString();
                            item.PostalZip = row["PostalZip"].ToString();
                            item.PoliceStation = row["PoliceStation"].ToString();
                            item.Address = row["Address"].ToString();
                            item.IncidentDate = row["IncidentDate"] != DBNull.Value ? Convert.ToDateTime(row["IncidentDate"]) : (DateTime?)null;
                            item.IncidentTime = row["IncidentTime"] != DBNull.Value ? Convert.ToDateTime(row["IncidentTime"]) : (DateTime?)null;
                            item.IncidentTimeEnd = row["IncidentTimeEnd"] != DBNull.Value ? Convert.ToDateTime(row["IncidentTimeEnd"]) : (DateTime?)null;
                            item.Latitude = row["Latitude"] != DBNull.Value ? Convert.ToSingle(row["Latitude"]) : (float?)null;
                            item.Longitude = row["Longitude"] != DBNull.Value ? Convert.ToSingle(row["Longitude"]) : (float?)null;
                            item.InjuredName = row["InjuredName"].ToString();
                            item.CasualtiesNames = row["CasualtiesNames"].ToString();
                            item.SuicideBomb = row["SuicideBomb"] != DBNull.Value ? Convert.ToInt32(row["SuicideBomb"]) : (int?)null;
                            item.CTWRemarks = row["CTWRemarks"].ToString();
                            item.Target = row["Target"].ToString();
                            item.Motive = row["Motive"].ToString();
                            item.Recoveries = row["Recoveries"].ToString();
                            item.CrimeSceneRecoveries = row["CrimeSceneRecoveries"].ToString();
                            item.CaseStatus = row["CaseStatus"].ToString();
                            item.strCaseProgress = row["strCaseProgress"].ToString();
                            item.Weapon = row["Weapon"].ToString();
                            item.ModusofOperandi = row["ModusofOperandi"].ToString();
                            item.dteSent = row["dteSent"] != DBNull.Value ? Convert.ToDateTime(row["dteSent"]) : (DateTime?)null;
                            item.NumberArrested = row["NumberArrested"] != DBNull.Value ? Convert.ToInt32(row["NumberArrested"]) : (int?)null;
                            item.PreIncidentThread = row["PreIncidentThread"].ToString();
                            item.Reportedby = row["Reportedby"].ToString();
                            item.strURN = row["strURN"].ToString();
                            item.INC_FirNo = Convert.ToInt32(row["INC_FirNo"]);

                            result.Add(item);
                        }
                    }

                    return result;

                }
            }
        }

    }
}

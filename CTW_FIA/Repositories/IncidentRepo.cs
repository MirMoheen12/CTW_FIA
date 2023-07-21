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
        private readonly IDatabaseRepo databaseRepo;

        public IncidentRepo(IConfiguration configuration, IDatabaseRepo databaseRepo)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
        }

        public object getIncidentID(string STRURN)
        {
        
            var dat = new {
                strURN= STRURN
            };
            var dbres = databaseRepo.ExecuteProc("LinkedRecordIncident_sel", databaseRepo.returnSppram(dat));
            return (databaseRepo.ConverttoObject(dbres, typeof(PreviewIncidentByStrUrn)).FirstOrDefault());
        
        }

        public List<PreviewIncident> getIncidentProvincewiese(string Province)
        {
            
            var dat = new
            {
                provinceName = Province
            };
            var dbres = databaseRepo.ExecuteProc("Incident_Provinces", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(PreviewIncident));
            var list = new List<PreviewIncident>();
            foreach (var item in dt)
            {
                list.Add((PreviewIncident)item);
            }
            return (list);
        }

    }
}

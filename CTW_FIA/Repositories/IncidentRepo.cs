using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class IncidentRepo : IIncident
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;

        public IncidentRepo(IConfiguration configuration, IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;
        }

        public bool AddNewIncident(Incident incident)
        {
            try
            {
                incident.strURN = databaseRepo.ExecuteProc("GetIncidentSTRURN", null).Rows[0][0].ToString();
                incident.textSearch = incident.strOperationName + "    " + incident.FirNo + "    " + incident.RegYear + "    " + incident.US + "    " + incident.strURN + "    " + incident.intID + "    " + incident.Country + "    " + incident.Province + "    " + incident.City + "    " + incident.District + "    " + incident.PoliceStation + "    " + incident.Weapon + "    " + incident.Target + "    " + incident.Motive + "    " + incident.strCaseProgress + "    " + incident.CaseStatus + "    " + incident.CasualtiesNames + "    " + incident.NumberKilled + "    " + incident.NumberInjured + "    " + incident.PostalZip + "    " + incident.CTWRemarks + "    " + incident.CreatedBy + "    " + incident.UpdatedBy + "    " + incident.CreatedOn + "    " + incident.UpdatedOn;
                incident.CreatedOn = DateTime.Now;
                appDbContext.Incident.Add(incident);
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }

        }

        public void DeleteIncident(string sTRUN)
        {
            var data = appDbContext.Person.Where(x => x.strURN == sTRUN).FirstOrDefault();
            data.IsDeleted = true;
            appDbContext.Person.Update(data);
            appDbContext.SaveChanges();
        }

        public Incident GetEditComponent(string sTRUN)
        {
            return appDbContext.Incident.Where(x => x.strURN == sTRUN).FirstOrDefault();
        }

        public PreviewIncidentByStrUrn getIncidentID(string STRURN)
        {
        
            var dat = new {
                strURN= STRURN
            };
            var dbres = databaseRepo.ExecuteProc("LinkedRecordIncident_sel", databaseRepo.returnSppram(dat));
            var rec = databaseRepo.ConverttoObject(dbres, typeof(PreviewIncidentByStrUrn)).Cast<PreviewIncidentByStrUrn>().ToList();
            return rec.FirstOrDefault();        
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


        public Incident GetEditIncident(string sTRUN)
        {
            return appDbContext.Incident.Where(x => x.strURN == sTRUN).FirstOrDefault();
        }

        public void PostEditIncident(Incident c)
        {
            appDbContext.Incident.Update(c);
            appDbContext.SaveChanges();
        }
    }
}

using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTW_FIA.Repositories
{
    public class PowerSourceRepo : IPowerSource
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
        private readonly IConfiguration configuration;
        public PowerSourceRepo(AppDbContext appDbContext,IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.appDbContext = appDbContext;
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }
        public bool AddPowerSource(PowerSource powerSource, String WhoCreatedName)
        {
            int psid = 0;
            if (appDbContext.PowerSource.Count() == 0)
            {
                psid = 1;
            }
            else
            {
                PowerSource powerSourc = appDbContext.PowerSource.OrderByDescending(p => p.IntID).FirstOrDefault();
                psid = powerSourc != null ? powerSourc.IntID : psid;
                psid++;
            }

            string id = "172CD22E00" + "PWS" + psid;

            powerSource.StrURN = id;
            powerSource.CreatedBy = WhoCreatedName;
            powerSource.UpdatedBy = WhoCreatedName;
            powerSource.TextSearch = powerSource.MemRemarks + " " + powerSource.StrURN + " " + powerSource.Category + " " + powerSource.Manufacturer + " " + powerSource.Markings + " " + powerSource.BatchCode + " " + powerSource.Diameter + " " + powerSource.NumberRecovered + " " + powerSource.Other + " " + powerSource.SerialNumber + " " + powerSource.Size + " " + powerSource.Colour + " " + powerSource.CountryOrigin + " " + powerSource.CountryRecovered;
            appDbContext.PowerSource.Add(powerSource);
            try
            {
                 appDbContext.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {

                throw;                
            }

        }

        public PowerSource GetpowerSourceById(string id)
        {
            var powerSource = appDbContext.PowerSource.Where(x => x.StrURN == id && x.IsDeleted == false).FirstOrDefault();

            if (powerSource == null)
            {
                return null;
            }

            return powerSource;
        }

        public List<PowerSource_sel_Result> AllPowerSource()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "PowerSource_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(PowerSource_sel_Result));
            var list = new List<PowerSource_sel_Result>();
            foreach (var item in res)
            {
                list.Add((PowerSource_sel_Result)item);
            }
            return list;
        }
    }
}

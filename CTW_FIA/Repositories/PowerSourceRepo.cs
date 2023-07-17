using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class PowerSourceRepo : IPowerSource
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public PowerSourceRepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

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

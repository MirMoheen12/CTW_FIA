using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class OrdinanceRepo:IOrdinance
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;

        public OrdinanceRepo(IConfiguration configuration, IDatabaseRepo databaseRepo)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
        }
        public List<Ordinance_sel_Result> AllOrdinance()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "Ordinance_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Ordinance_sel_Result));
            var list = new List<Ordinance_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Ordinance_sel_Result)item);
            }
            return list;
        }
    }
}

using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class FireamsRepo:IFearams
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public FireamsRepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }

        public List<Firearms_sel_Result> allfearms()
        {
          
            var dat = databaseRepo.ExecuteProc("Firearms_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Firearms_sel_Result));
            var list = new List<Firearms_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Firearms_sel_Result)item);
            }
            return list;
        }

        public QuickSearchFirearms_sel_Result GetFiremsByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchFirearms_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchFirearms_sel_Result));
            var list = new List<QuickSearchFirearms_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchFirearms_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

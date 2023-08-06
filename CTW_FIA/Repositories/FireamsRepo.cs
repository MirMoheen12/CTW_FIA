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

        public Firearms_sel_Result GetGroupsByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("Firearms_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(Firearms_sel_Result));
            var list = new List<Firearms_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((Firearms_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

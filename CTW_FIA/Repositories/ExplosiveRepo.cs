using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Repositories
{
    public class ExplosiveRepo:IExplosive
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;

        public ExplosiveRepo(IConfiguration configuration, IDatabaseRepo databaseRepo)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
        }
        public List<Explosives_sel_Result> AllExplosive()
        {
           
            var dat = databaseRepo.ExecuteProc("Explosives_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Explosives_sel_Result));
            var list = new List<Explosives_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Explosives_sel_Result)item);
            }
            return list;
        }
    }
}

using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
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
        public List<Explosive> AllExplosive()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "Explosives_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Explosive));
            var list = new List<Explosive>();
            foreach (var item in res)
            {
                list.Add((Explosive)item);
            }
            return list;
        }
    }
}

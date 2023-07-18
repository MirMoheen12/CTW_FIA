using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Detanatorsrepo : IDetonators
    {

        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public Detanatorsrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }


        public List<DetonatorDetails_sel_Result> alldetonators()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "DetonatorDetails_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(DetonatorDetails_sel_Result));
            var list = new List<DetonatorDetails_sel_Result>();
            foreach (var item in res)
            {
                list.Add((DetonatorDetails_sel_Result)item);
            }
            return list;
        }
 
    }
}

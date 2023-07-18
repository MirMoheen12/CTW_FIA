using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class CBRNRepo:ICBRN
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public CBRNRepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }



        public List<CBRN_sel_Result> Allcbrn()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "CBRN_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(CBRN_sel_Result));
            var list = new List<CBRN_sel_Result>();
            foreach (var item in res)
            {
                list.Add((CBRN_sel_Result)item);
            }
            return list;
        }
    }
}

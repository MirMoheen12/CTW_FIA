using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class chemicalrepo:Ichemical
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public chemicalrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }


        public List<Chemicals_sel_Result> allChemical()
        {
         
            var dat = databaseRepo.ExecuteProc("Chemicals_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Chemicals_sel_Result));
            var list = new List<Chemicals_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Chemicals_sel_Result)item);
            }
            return list;
        }
    }
}

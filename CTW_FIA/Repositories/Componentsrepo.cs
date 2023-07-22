using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Componentsrepo:IComponents
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public Componentsrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }

        public List<Components_sel_Result> AllComponents()
        {
            
            var dat = databaseRepo.ExecuteProc( "Components_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Components_sel_Result));
            var list = new List<Components_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Components_sel_Result)item);
            }
            return list;
        }
    }
}

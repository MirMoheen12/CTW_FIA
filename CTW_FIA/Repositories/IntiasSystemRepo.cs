using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class IntiasSystemRepo : IIntianSystem
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;

        public IntiasSystemRepo(IConfiguration configuration, IDatabaseRepo databaseRepo)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
        }
        public List<InitiationSystems_sel_Result> AllSystem()
        {
           
            var dat = databaseRepo.ExecuteProc("InitiationSystems_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(InitiationSystems_sel_Result));
            var list = new List<InitiationSystems_sel_Result>();
            foreach (var item in res)
            {
                list.Add((InitiationSystems_sel_Result)item);
            }
            return list;
        }
     
    }
}

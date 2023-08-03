using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Equipemtsrepo : IEquipments
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public Equipemtsrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }

        public List<Equipment_sel_Result> AllEquipments()
        {
         
            var dat = databaseRepo.ExecuteProc("Equipment_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Equipment_sel_Result));
            var list = new List<Equipment_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Equipment_sel_Result)item);
            }
            return list;
        }

        public Equipment_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchEquipment_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(Equipment_sel_Result));
            var list = new List<Equipment_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((Equipment_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

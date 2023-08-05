using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System;

namespace CTW_FIA.Repositories
{
    public class Equipemtsrepo : IEquipments
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        private readonly AppDbContext appDbContext;
        public Equipemtsrepo(IDatabaseRepo databaseRepo, IConfiguration configuration, AppDbContext appDbContext)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;
            this.appDbContext = appDbContext;
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

        public bool AddNewEquipment(Equipment equipment)
        {
            try
            {
                equipment.strURN = databaseRepo.ExecuteProc("GetEQSTRURN", null).Rows[0][0].ToString();
                equipment.textSearch = equipment.strURN + " " + equipment.textSearch;
                equipment.CreatedOn = DateTime.Now;
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public QuickSearchEquipment_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchCommunications_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchOrdinance_sel_Result));
            var list = new List<QuickSearchEquipment_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchEquipment_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

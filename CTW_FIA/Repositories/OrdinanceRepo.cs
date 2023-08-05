using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System;

namespace CTW_FIA.Repositories
{
    public class OrdinanceRepo:IOrdinance
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;

        public OrdinanceRepo(IConfiguration configuration, IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;
        }

        public bool AddNewOrdinance(Ordnance ordinance)
        {
            try
            {
                ordinance.strURN = databaseRepo.ExecuteProc("GetORDNanceSTRURN", null).Rows[0][0].ToString();
                ordinance.textSearch = ordinance.strURN + "  " + ordinance.BrandName;
                ordinance.CreatedOn = DateTime.Now;
                appDbContext.Ordinance.Add(ordinance);
                appDbContext.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
            
             
        }

        public List<Ordinance_sel_Result> AllOrdinance()
        {
            
            var dat = databaseRepo.ExecuteProc("Ordinance_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Ordinance_sel_Result));
            var list = new List<Ordinance_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Ordinance_sel_Result)item);
            }
            return list;
        }

        public QuickSearchOrdinance_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchOrdinance_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchOrdinance_sel_Result));
            var list = new List<QuickSearchOrdinance_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchOrdinance_sel_Result)item);
            }
            return list.FirstOrDefault();
        }

        public QuickSearchOrdinance_sel_Result OrdinanceDetails(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchOrdinance_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchOrdinance_sel_Result));
            var list = new List<QuickSearchOrdinance_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchOrdinance_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

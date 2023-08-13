using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;
using Microsoft.EntityFrameworkCore;

namespace CTW_FIA.Repositories
{
    public class ExplosiveRepo:IExplosive
    {
        private readonly AppDbContext appDbContext;
        private readonly IDatabaseRepo databaseRepo;

        public ExplosiveRepo(AppDbContext appDbContext, IDatabaseRepo databaseRepo)
        {
            this.appDbContext = appDbContext;
            this.databaseRepo = databaseRepo;
        }

        public bool AddExplosive(Explosive E)
        {
            try
            {
                E.CreatedOn = DateTime.Now;
                E.strURN = databaseRepo.ExecuteProc("GetExpSTRURN", null).Rows[0][0].ToString();
                E.textSearch = E.strURN + "   " + E.BrandName + "   " + E.CountryOrigin;
                appDbContext.Explosive.Add(E);
                appDbContext.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {
                return false;
                //throw;
            }

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

        public void EditExplosives(string sTRUN)
        {
            throw new NotImplementedException();
        }

        public QuickSearchExplosives_sel_Result GetExplosiveByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchExplosives_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchExplosives_sel_Result));
            var list = new List<QuickSearchExplosives_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchExplosives_sel_Result)item);
            }
            return list.FirstOrDefault();
        }

        void IExplosive.DeleteExplosives(string sTRUN)
        {
            var data = appDbContext.Person.Where(x => x.strURN == sTRUN).FirstOrDefault();
            data.IsDeleted = true;
            appDbContext.Person.Update(data);
            appDbContext.SaveChanges();
        }
    }
}

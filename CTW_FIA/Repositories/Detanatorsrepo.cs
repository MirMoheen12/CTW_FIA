using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Detanatorsrepo : IDetonators
    {

        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
        public Detanatorsrepo(IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;

        }

        public bool AddDetonators(Detonator D)
        {
            try
            {
                D.strURN = databaseRepo.ExecuteProc("GetDetonatorsSTRURN", null).Rows[0][0].ToString();
                D.CreatedOn = DateTime.Now;
                D.textSearch = D.strURN + "  " + D.Category + "   " + D.Type;
                appDbContext.Detonator.Add(D);
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DetonatorDetails_sel_Result> alldetonators()
        {
         
            var dat = databaseRepo.ExecuteProc("DetonatorDetails_sel", null);
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

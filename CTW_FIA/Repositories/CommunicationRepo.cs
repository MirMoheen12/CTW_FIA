using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class CommunicationRepo:ICommunication
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
        public CommunicationRepo(IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.appDbContext=appDbContext;
            this.databaseRepo = databaseRepo;

        }

        public bool AddNewcommunication(Communications c)
        {
            try
            {
                c.strURN = databaseRepo.ExecuteProc("GetComSTRURN", null).Rows[0][0].ToString();
                c.textSearch = c.strURN + " " + c.CommName + " " + c.CommType + " " + c.CommDescription + " " + c.CountryOrigin;
                c.CreatedOn = DateTime.Now;
                appDbContext.Communications.Add(c);
                appDbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Communications_sel> AllCommunication()
        {
            
            var dat = databaseRepo.ExecuteProc("Communications_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Communications_sel));
            var list = new List<Communications_sel>();
            foreach (var item in res)
            {
                list.Add((Communications_sel)item);
            }
            return list;

        }
        public QuickSearchCommunications_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchCommunications_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchCommunications_sel_Result));
            var list = new List<QuickSearchCommunications_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchCommunications_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

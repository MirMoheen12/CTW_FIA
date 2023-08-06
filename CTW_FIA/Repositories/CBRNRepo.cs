using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class CBRNRepo:ICBRN
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        private readonly AppDbContext aappDbContext;
        public CBRNRepo(IDatabaseRepo databaseRepo, IConfiguration configuration, AppDbContext aapDbContext)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;
            this.aappDbContext = aapDbContext;
        }

        public bool AddNewComponent(CBRN cBRN)
        {
            try
            {
                cBRN.strURN = databaseRepo.ExecuteProc("GetCBRNSTRURN", null).Rows[0][0].ToString();
                cBRN.textSearch = cBRN.strURN + " " + cBRN.textSearch;
                cBRN.CreatedOn = DateTime.Now;
                aappDbContext.CBRNs.Add(cBRN);
                aappDbContext.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public List<CBRN_sel_Result> Allcbrn()
        {
          
            var dat = databaseRepo.ExecuteProc("CBRN_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(CBRN_sel_Result));
            var list = new List<CBRN_sel_Result>();
            foreach (var item in res)
            {
                list.Add((CBRN_sel_Result)item);
            }
            return list;
        }

        public CBRN_sel_Result GetGroupsByStrurn(string sTRUN)
        {

            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("CBRN_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(CBRN_sel_Result));
            var list = new List<CBRN_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((CBRN_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

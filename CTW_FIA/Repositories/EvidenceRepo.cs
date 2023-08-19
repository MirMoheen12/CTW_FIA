using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class EvidenceRepo : IEvidence
    {
        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
        public EvidenceRepo(IConfiguration configuration, IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;
        }
        public bool AddNewEvidence(Evidence evidence)
        {
            try
            {
                evidence.strURN = databaseRepo.ExecuteProc("GetEvedSTRURN", null).Rows[0][0].ToString();
                evidence.textSearch=evidence.strURN+"  "+evidence.textSearch;
                evidence.CreatedOn = DateTime.Now;
                appDbContext.Evidence.Add(evidence);
                appDbContext.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Evidence> AllEvidence()
        {

            var dat = databaseRepo.ExecuteProc("Ordinance_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Evidence));
            var list = new List<Evidence>();
            foreach (var item in res)
            {
                list.Add((Evidence)item);
            }
            return list;
        }


        public Evidence GetEvidenceByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchEvidence_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(Evidence));
            var list = new List<Evidence>();
            foreach (var item in dt)
            {
                list.Add((Evidence)item);
            }
            return list.FirstOrDefault();
        }

        public void PostEditEvidence(Evidence c)
        {
            appDbContext.Evidence.Update(c);
            appDbContext.SaveChanges();
        }
    }
}

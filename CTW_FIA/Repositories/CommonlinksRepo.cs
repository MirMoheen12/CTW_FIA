using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Repositories
{
    public class CommonlinksRepo:ICommonlinks
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
        public CommonlinksRepo(IDatabaseRepo databaseRepo,AppDbContext appDbContext) 
        {
            this.databaseRepo=databaseRepo;
            this.appDbContext=appDbContext;

        }

        public bool CreateCommonlinks(string srcSTRURN, string dstSTRURN, string DbSrc, string DbDest, string linkType,string textsearch, string SE = "", string RE = "", string RL="", string BI="")
        {
            try
            {
                CommonLinks commonLinks = new CommonLinks();
                commonLinks.strURN = databaseRepo.ExecuteProc("GetCommonlinksSTRURN", null).Rows[0][0].ToString();
                commonLinks.strLink = linkType;
                commonLinks.strURNSource = srcSTRURN;
                commonLinks.strURNDest = dstSTRURN;
                commonLinks.textSearch = textsearch;
                commonLinks.intDbIdSource = Convert.ToInt16(appDbContext.DatabaseList.Where(x => x.strTable == DbSrc).Select(x => x.intType).FirstOrDefault());
                commonLinks.intDbIdDest = Convert.ToInt16(appDbContext.DatabaseList.Where(x => x.strTable == DbDest).Select(x => x.intType).FirstOrDefault());
                commonLinks.CreatedOn = DateTime.Now;
                appDbContext.CommonLinks.Add(commonLinks);
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                AddErrorLog(e.Message);
                return false;
            }


        }
        public List<CommonLinks> GetallLinks()
        {
            var dat=appDbContext.CommonLinks.Take(100).ToList();
            return dat;
        }
        private void AddErrorLog(string Msg)
        {
            var dat = new
            {
                Msg = Msg
            };
            var dbres = databaseRepo.ExecuteProc("InsertErrorLog", databaseRepo.returnSppram(Msg));
        }
        public List<GraphDto> getAlllinksCount(string StrUrn)
        {
            var dat = new
            {
                Strurn = StrUrn
            };
            var dbres = databaseRepo.ExecuteProc("GetRecordsLink", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(GraphDto));
            var list = new List<GraphDto>();
            foreach (var item in dt)
            {
                list.Add((GraphDto)item);
            }
            return (list);
          
        }
    }
}

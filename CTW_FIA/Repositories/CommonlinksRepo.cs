using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Repositories
{
    public class CommonlinksRepo:ICommonlinks
    {
        private readonly IDatabaseRepo databaseRepo;
        public CommonlinksRepo(IDatabaseRepo databaseRepo) 
        {
            this.databaseRepo=databaseRepo;

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

using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    
    public class QuickSearchRepo : IQuickSearch
    {
        private readonly IDatabaseRepo databaseRepo;
        public QuickSearchRepo(IDatabaseRepo databaseRepo)
        {

            this.databaseRepo = databaseRepo;

        }
        public List<QuickSearchModel> getSearchdata(string SearchValue)
        {
            var dat = new
            {
                textSearch = SearchValue
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearch_sel_web", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchModel));
            return(dt.Cast<QuickSearchModel>().ToList());
           
        }
    }
}

using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Repositories
{
    public class JsonRepo : IJson
    {
        private readonly AppDbContext appDbContext;
        public JsonRepo(AppDbContext appDbContext)
        {

            this.appDbContext = appDbContext;

        }
        public List<ReportingAgency> GetReportingAgencies()
        {
            var data = appDbContext.ReportingAgency.ToList();
            return data;
        }
    }
}

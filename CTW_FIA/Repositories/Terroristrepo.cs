using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Terroristrepo : ITerrorist
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        private readonly AppDbContext dbContext;
        public Terroristrepo(IDatabaseRepo databaseRepo, IConfiguration configuration, AppDbContext dbContext)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;
            this.dbContext = dbContext;
        }

        public List<ReportingAgency> AllAgencies()
        {
            var data = dbContext.ReportingAgency.ToList();
            return (data);
        }

        public List<TerroristGroup_Records> GetAllTerrorist()
        {
            
            var dbres = databaseRepo.ExecuteProc( "Groups_sel2", null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(TerroristGroup_Records));
            var list = new List<TerroristGroup_Records>();
            foreach (var item in dt)
            {
                list.Add((TerroristGroup_Records)item);
            }
            return (list);

        }

        public List<QuickSearchPerson_sel_Result> GetPeronByID(string STRURN)
        {
            var dat = new
            {
                textSearch = STRURN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchPerson_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchPerson_sel_Result));
            var list = new List<QuickSearchPerson_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchPerson_sel_Result)item);
            }
            return (list);
        }

        public List<NewPerson_Provinces_Result> GetPeronProvincewise(string Province)
        {
           
            var dat = new
            {
                provinceName = Province
            };
            var dbres = databaseRepo.ExecuteProc("NewPerson_Provinces", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(NewPerson_Provinces_Result));
            var list = new List<NewPerson_Provinces_Result>();
            foreach (var item in dt)
            {
                list.Add((NewPerson_Provinces_Result)item);
            }
            return (list);
           
        }
    }
}

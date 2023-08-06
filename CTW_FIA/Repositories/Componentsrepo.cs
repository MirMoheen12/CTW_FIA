using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Componentsrepo:IComponents
    {

        private readonly IConfiguration configuration;
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;

        public Componentsrepo(IConfiguration configuration, IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.configuration = configuration;
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;
        }

        public bool AddNewComponent(Components component)
        {
            try
            {
                component.strURN = databaseRepo.ExecuteProc("GetCompSTRURN", null).Rows[0][0].ToString();
                component.textSearch = component.strURN + "  " + component.Manufacturer;
                component.CreatedOn = DateTime.Now;
                appDbContext.Components.Add(component);
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Components_sel_Result> AllComponents()
        {
            
            var dat = databaseRepo.ExecuteProc( "Components_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Components_sel_Result));
            var list = new List<Components_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Components_sel_Result)item);
            }
            return list;
        }

        public Components_sel_Result GetComponByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("Components_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(Components_sel_Result));
            var list = new List<Components_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((Components_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

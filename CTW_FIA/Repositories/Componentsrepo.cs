using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System.ComponentModel;

namespace CTW_FIA.Repositories
{
    public class Componentsrepo : IComponents
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
                component.IsDeleted = false;
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

            var dat = databaseRepo.ExecuteProc("Components_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Components_sel_Result));
            var list = new List<Components_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Components_sel_Result)item);
            }
            return list;
        }

        public void DeleteComponents(string sTRUN)
        {
            var data = appDbContext.Person.Where(x => x.strURN == sTRUN).FirstOrDefault();
            data.IsDeleted = true;
            appDbContext.Person.Update(data);
            appDbContext.SaveChanges();
        }

        public QuickSearchComponents_sel_Result GetComponByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchComponents_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchComponents_sel_Result));
            var list = new List<QuickSearchComponents_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchComponents_sel_Result)item);
            }
            return list.FirstOrDefault();
        }

        public Components GetEditComponent(string sTRUN)
        {
            return appDbContext.Components.Where(x => x.strURN == sTRUN).FirstOrDefault();
        }

        public void PostEditComponent(Components c)
        {
            appDbContext.Components.Update(c);
            appDbContext.SaveChanges();
        }
    }
}

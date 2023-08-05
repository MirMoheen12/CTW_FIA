using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System;

namespace CTW_FIA.Repositories
{
    public class IntiasSystemRepo : IIntianSystem
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        private readonly AppDbContext appDbContext;
        public IntiasSystemRepo(IDatabaseRepo databaseRepo, IConfiguration configuration, AppDbContext appDbContext)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;
            this.appDbContext = appDbContext;
        }

        public bool AddNewInitiation(InitiationSystem ins)
        {
            try
            {
                ins.strURN = databaseRepo.ExecuteProc("", null).Rows[0][0].ToString();
                ins.textSearch = ins.strURN + " " + ins.textSearch;
                ins.CreatedOn = DateTime.Now;
               //appDbContext.InitiationSystems.Add(ins);
               // appDbContext.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public List<InitiationSystems_sel_Result> AllSystem()
        {
           
            var dat = databaseRepo.ExecuteProc("InitiationSystems_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(InitiationSystems_sel_Result));
            var list = new List<InitiationSystems_sel_Result>();
            foreach (var item in res)
            {
                list.Add((InitiationSystems_sel_Result)item);
            }
            return list;
        }
     
    }
}

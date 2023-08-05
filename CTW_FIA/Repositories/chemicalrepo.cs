using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTW_FIA.Repositories
{
    public class chemicalrepo:Ichemical
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public chemicalrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }


        public List<Chemicals_sel_Result> allChemical()
        {
         
            var dat = databaseRepo.ExecuteProc("Chemicals_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Chemicals_sel_Result));
            var list = new List<Chemicals_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Chemicals_sel_Result)item);
            }
            return list;
        }

        public Chemicals_sel_Result GetGroupsByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("Chemicals_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(Chemicals_sel_Result));
            var list = new List<Chemicals_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((Chemicals_sel_Result)item);
            }
            return list.FirstOrDefault();
        }
    }
}

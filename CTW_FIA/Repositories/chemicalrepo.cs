using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace CTW_FIA.Repositories
{
    public class chemicalrepo : Ichemical
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        private readonly AppDbContext dbContext;
        public chemicalrepo(IDatabaseRepo databaseRepo, IConfiguration configuration,AppDbContext appDbContext)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;
            this.dbContext = appDbContext;

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

        public QuickSearchChemicals_sel_Result ChemicalByStrurn(string sTRUN)
        {
            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchChemicals_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchChemicals_sel_Result));
            var list = new List<QuickSearchChemicals_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchChemicals_sel_Result)item);
            }
            return list.FirstOrDefault();
        }

        public void DeleteChemicals(string sTRUN)
        {
            var data = dbContext.Person.Where(x => x.strURN == sTRUN).FirstOrDefault();
            data.IsDeleted = true;
            dbContext.Person.Update(data);
            dbContext.SaveChanges();
        }
        public void PostEditChemical(Chemical c)
        {
            dbContext.Chemicals.Update(c);
            dbContext.SaveChanges();
        }
    }
}

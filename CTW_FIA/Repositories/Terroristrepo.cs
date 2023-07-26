using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System;
using System.Data;

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

        public bool AddNewPerson(Person P)
        {
         
            try
            {
                AddNewTerrorist(P);
                return true;
            }
            catch (Exception e)
            {
                AddErrorLog(e.Message.ToString());
                return false;

            }
        }

        public List<ReportingAgency> AllAgencies()
        {
            var data = dbContext.ReportingAgency.ToList();
            return (data);
        }

        public List<CountryList> AllCountry()
        {
            var dbres = databaseRepo.ExecuteProc("getAllCountries",null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(CountryList));
            var list = new List<CountryList>();
            foreach (var item in dt)
            {
                list.Add((CountryList)item);
            }
            return (list);
        }

        public List<DistrictList> GetAllDistrictByProvince(string Province)
        {
            var dat = new
            {
                Province = Province
            };
            var dbres = databaseRepo.ExecuteProc("DistrictList_Web", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(DistrictList));
            var list = new List<DistrictList>();
            foreach (var item in dt)
            {
                list.Add((DistrictList)item);
            }
            return (list);
        }

        public List<ProvinceList> GetALlprovinceCountryWise(string Country)
        {
            var dbres = databaseRepo.ExecuteProc("ProvinceList_sel", null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(ProvinceList));
            var list = new List<ProvinceList>();
            foreach (var item in dt)
            {
                list.Add((ProvinceList)item);
            }
            return (list);
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

        private bool AddNewTerrorist(Person P)
        {
           
                P.strURN = databaseRepo.ExecuteProc("GetPersonSTRURN", null).Rows[0][0].ToString();
                var res = dbContext.Person.Add(P);
                P.CreatedOn = DateTime.Now;
                P.textSearch = P.Name + " " + P.strURN + " " + P.memRemarks + " " + P.CNIC.ToString();
                dbContext.SaveChanges();
                return true;
     
            
        }
        private void AddErrorLog(string Msg)
        {
            var dat = new
            {
                Msg = Msg
            };
            var dbres = databaseRepo.ExecuteProc("InsertErrorLog", databaseRepo.returnSppram(Msg));
        }
    }
}

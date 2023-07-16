using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class Terroristrepo : ITerrorist
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public Terroristrepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;

            this.configuration = configuration;

        }
        public List<NewPerson_Provinces_Result> GetPeronProvincewise(string Province)
        {
            string con = configuration.GetConnectionString("DefaultConnection");
            var dat = new
            {
                provinceName = Province
            };
            var dbres = databaseRepo.ExecuteProc(con, "NewPerson_Provinces", databaseRepo.returnSppram(dat));
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

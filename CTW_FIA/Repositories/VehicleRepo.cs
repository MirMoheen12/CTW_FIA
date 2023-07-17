using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;
using System.Configuration;

namespace CTW_FIA.Repositories
{
    public class VehicleRepo : IVehicle
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public VehicleRepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.databaseRepo = databaseRepo;
            this.configuration = configuration;

        }
        public List<Vehicles_sel_Result> AllVehicle()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var dat = databaseRepo.ExecuteProc(connectionString, "Vehicles_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Vehicles_sel_Result));
            var list = new List<Vehicles_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Vehicles_sel_Result)item);
            }
            return list;
        }
    }
}

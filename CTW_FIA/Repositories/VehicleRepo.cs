using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System.Configuration;

namespace CTW_FIA.Repositories
{
    public class VehicleRepo : IVehicle
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext appDbContext;
      
        public VehicleRepo(IDatabaseRepo databaseRepo, AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.databaseRepo = databaseRepo;
          

        }

        public bool AddNewVehicle(Vehicle vehicle)
        {
            try
            {
                vehicle.strURN = databaseRepo.ExecuteProc("GetVehicleSTRURN", null).Rows[0][0].ToString();
                vehicle.CreatedOn = DateTime.Now;
                vehicle.textSearch = vehicle.strURN + "  " + vehicle.VehicleType + "  " + vehicle.VehicleSubType + "  " + vehicle.Color + " " + vehicle.RegistrationNo;
                appDbContext.Vehicle.Add(vehicle);
                appDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
               
            }

        }

        public List<Vehicles_sel_Result> AllVehicle()
        {
          
            var dat = databaseRepo.ExecuteProc("Vehicles_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Vehicles_sel_Result));
            var list = new List<Vehicles_sel_Result>();
            foreach (var item in res)
            {
                list.Add((Vehicles_sel_Result)item);
            }
            return list;
        }

        public QuickSearchVehicles_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchVehicles_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchVehicles_sel_Result));
            var list = new List<QuickSearchVehicles_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchVehicles_sel_Result)item);
            }
            return list.FirstOrDefault();

        }
    }
}

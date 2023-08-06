using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IVehicle
    {
        public List<Vehicles_sel_Result> AllVehicle();
        public bool AddNewVehicle(Vehicle vehicle);
        public QuickSearchVehicles_sel_Result GetVehcileByStrurn(string STRURN);
    }
}

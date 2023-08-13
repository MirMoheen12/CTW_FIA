using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IEquipments
    {
       public bool AddNewEquipment(Equipment equ);
        public List<Equipment_sel_Result> AllEquipments();
        void DeleteEquipment(string sTRUN);
        void EditEquipment(string sTRUN);
        public QuickSearchEquipment_sel_Result GetEquByStrurn(string Strurn);
    }
}

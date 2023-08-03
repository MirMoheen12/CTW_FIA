using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IEquipments
    {
        public List<Equipment_sel_Result> AllEquipments();
        public QuickSearchEquipment_sel_Result GetGroupsByStrurn(string Strurn);
    }
}

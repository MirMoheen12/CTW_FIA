using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IPowerSource
    {
        public List<PowerSource_sel_Result> AllPowerSource();
    }
}

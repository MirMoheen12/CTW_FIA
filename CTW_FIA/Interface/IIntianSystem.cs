using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IIntianSystem
    {
        public bool AddNewInitiation(InitiationSystem ins);
        public List<InitiationSystems_sel_Result> AllSystem();
        public QuickSearchInitiationSystems_sel_Result GetIntianDystmByStrurn(string sTRUN);
    }
}

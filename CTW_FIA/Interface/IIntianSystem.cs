using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IIntianSystem
    {
        public bool AddNewInitiation(InitiationSystem ins);
        public List<InitiationSystems_sel_Result> AllSystem();
        void DeleteInitiationSystem(string sTRUN);
        void EditInitiationSystem(string sTRUN);
        public QuickSearchInitiationSystems_sel_Result GetIntianDystmByStrurn(string sTRUN);
        void PostEditInitiationSystem(InitiationSystem c);
    }
}

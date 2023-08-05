using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface ICommunication
    {
        public List<Communications_sel> AllCommunication();
        public bool AddNewcommunication(Communications c);
        public QuickSearchCommunications_sel_Result communicationDetails(string Strurn);
    }
}

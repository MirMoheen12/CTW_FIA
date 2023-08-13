using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IFearams
    {
        public List<Firearms_sel_Result> allfearms();
        void DeleteFirearms(string sTRUN);
        void EditFirearms(string sTRUN);
        public QuickSearchFirearms_sel_Result GetFiremsByStrurn(string sTRUN);
    }
}

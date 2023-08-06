using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface ICBRN
    {
        public bool AddNewComponent(CBRN c);
        public List<CBRN_sel_Result> Allcbrn();
        CBRN_sel_Result GetGroupsByStrurn(string sTRUN);
    }
}

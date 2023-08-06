using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface ICBRN
    {
        public bool AddNewComponent(CBRN c);
        public List<CBRN_sel_Result> Allcbrn();
       public QuickSearchCBRN_sel_Result getCBRNByStrurn(string sTRUN);
    }
}

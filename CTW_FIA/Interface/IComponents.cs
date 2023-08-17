using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IComponents
    {
         public bool AddNewComponent(Components c);
         public List<Components_sel_Result> AllComponents();
        void DeleteComponents(string sTRUN);

        public Components GetEditComponent(string sTRUN);
        public void PostEditComponent(Components c);
        public QuickSearchComponents_sel_Result GetComponByStrurn(string sTRUN);
    }
}

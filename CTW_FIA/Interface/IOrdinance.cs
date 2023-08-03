using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IOrdinance
    {
        public List<Ordinance_sel_Result> AllOrdinance();
        public bool AddNewOrdinance(Ordnance ordinance);
        public QuickSearchOrdinance_sel_Result OrdinanceDetails(string Strurn);
    }
}

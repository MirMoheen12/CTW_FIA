using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface Ichemical
    {
        public List<Chemicals_sel_Result> allChemical();
       public QuickSearchChemicals_sel_Result ChemicalByStrurn(string sTRUN);
    }
}

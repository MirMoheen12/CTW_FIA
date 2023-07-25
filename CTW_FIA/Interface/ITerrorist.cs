using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface ITerrorist
    {
        public List<NewPerson_Provinces_Result> GetPeronProvincewise(string Province);
        public List<QuickSearchPerson_sel_Result> GetPeronByID(string STRURN);
        public List<TerroristGroup_Records> GetAllTerrorist();
        public List<ReportingAgency> AllAgencies();

    }
}

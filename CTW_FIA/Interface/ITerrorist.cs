using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface ITerrorist
    {
        public List<NewPerson_Provinces_Result> GetPeronProvincewise(string Province);
        public QuickSearchPerson_sel_Result GetPeronByID(string STRURN);
        public List<TerroristGroup_Records> GetAllTerrorist();
        public List<ReportingAgency> AllAgencies();
        public List<CountryList> AllCountry();
        public List<DistrictList> GetAllDistrictByProvince(string Province);
        public List<ProvinceList> GetALlprovinceCountryWise(string Country);
        public bool AddNewPerson(Person P, IFormFile? formFile);
        public QuickSearchGroups_sel_Result GetGroupsByStrurn(string Strurn);
        public List<PoliceStation> AllPliceStation();
        public bool AddNewGroup(Group group);

    }
}

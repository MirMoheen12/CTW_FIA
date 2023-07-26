using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class CountryList
    {

        public string? strURN { get; set; }
        public string? strCountryCode { get; set; }
        public string? strCountry { get; set; }
        public string? intID { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? IsDeleted { get; set; }
        public string? textSearch { get; set; }
    }

}

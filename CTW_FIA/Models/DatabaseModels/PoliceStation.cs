using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class PoliceStation
    {
    
        public string? strURN { get; set; }
        public string? strPoliceStation { get; set; }
        public string? CityListstrURN { get; set; }
     
        public string intID { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? IsDeleted { get; set; }
        public string? textSearch { get; set; }
        public string DistrictListintID { get; set; }
    }

}

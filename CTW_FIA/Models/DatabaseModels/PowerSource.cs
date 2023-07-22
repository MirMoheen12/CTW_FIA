
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class PowerSource
    {
        [Key]
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Nullable<float> Width { get; set; }
        public string Other { get; set; }
        public string Make { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOrigin { get; set; }
        public string CountryRecovered { get; set; }
        public string Markings { get; set; }
        public string Colour { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<float> Height { get; set; }
        public Nullable<float> Voltage { get; set; }
        public Nullable<float> Diameter { get; set; }
        public Nullable<float> Length { get; set; }
        public string memRemarks { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string BatchCode { get; set; }
        public Nullable<int> NumberRecovered { get; set; }
        public string Size { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

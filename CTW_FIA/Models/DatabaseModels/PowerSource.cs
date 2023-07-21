using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class PowerSource
    {
        public string StrURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Width { get; set; }
        public string Other { get; set; }
        public string Make { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOrigin { get; set; }
        public string CountryRecovered { get; set; }
        public string Markings { get; set; }
        public string Colour { get; set; }
        public string SerialNumber { get; set; }
        public string Height { get; set; }
        public string Voltage { get; set; }
        public string Diameter { get; set; }
        public string Length { get; set; }
        public string MemRemarks { get; set; }
        [Key]
        public int IntID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string TextSearch { get; set; }
        public string BatchCode { get; set; }
        public int NumberRecovered { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

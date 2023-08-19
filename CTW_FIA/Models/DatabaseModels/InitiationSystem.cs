using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class InitiationSystem
    {
        [Key]
        public string strURN { get; set; }
        public string Category { get; set; }
        public bool Electric { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public string Make { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOrigin { get; set; }
        public string Size { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Diameter { get; set; }
        public int Voltage { get; set; }
        public string Markings { get; set; }
        public string BatchCode { get; set; }
        public string SerialNumbers { get; set; }
        public string Colour { get; set; }
        public int NumberRecovered { get; set; }
        public string CountryRecovered { get; set; }
        public string memRemarks { get; set; }
        public DateTime dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

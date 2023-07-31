using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Ordnance
    {
        [Key]
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public string Manufacturer { get; set; }
        public string BrandName { get; set; }
        public string CountryRecovered { get; set; }
        public string CountryOrigin { get; set; }
        public float? ExplosiveWeight { get; set; }
        public string memMarkings { get; set; }
        public string BatchCode { get; set; }
        public string SerialNumbers { get; set; }
        public string Colour { get; set; }
        public float? Calibre { get; set; }
        public bool? HeadStamp { get; set; }
        public float? Length { get; set; }
        public float? Width { get; set; }
        public float? Depth { get; set; }
        public float? Diameter { get; set; }
        public float? NumberRecovered { get; set; }
        public string Remarks { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }
}

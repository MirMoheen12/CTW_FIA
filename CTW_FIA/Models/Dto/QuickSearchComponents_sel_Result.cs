using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchComponents_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Int ID")]
        public string? intID { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Country Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Material")]
        public string? Material { get; set; }

        [Display(Name = "Manufacturer")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Method Delivery")]
        public string? MethodDelivery { get; set; }

        [Display(Name = "Quantity Weight")]
        public string? QuantityWeight { get; set; }

        [Display(Name = "Quantity No")]
        public string? QuantityNo { get; set; }

        [Display(Name = "Country Recovered")]
        public string? CountryRecovered { get; set; }

        [Display(Name = "Length")]
        public string? Length { get; set; }

        [Display(Name = "Width")]
        public string? Width { get; set; }

        [Display(Name = "Height")]
        public string? Height { get; set; }

        [Display(Name = "Diameter")]
        public string? Diameter { get; set; }

        [Display(Name = "Colour")]
        public string? Colour { get; set; }

        [Display(Name = "Markings")]
        public string? Markings { get; set; }

        [Display(Name = "Mem Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Flag")]
        public string? flag { get; set; }

        [Display(Name = "Table Name")]
        public string? tableName { get; set; }

        [Display(Name = "Text Search")]
        public string? textSearch { get; set; }
    }
}

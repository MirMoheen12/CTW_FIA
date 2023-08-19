using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchPowerSource_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Category")]
        public string? Category { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Width")]
        public string? Width { get; set; }

        [Display(Name = "Other")]
        public string? Other { get; set; }

        [Display(Name = "Make")]
        public string? Make { get; set; }

        [Display(Name = "Manufacturer")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Country of Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Country Recovered")]
        public string? CountryRecovered { get; set; }

        [Display(Name = "Markings")]
        public string? Markings { get; set; }

        [Display(Name = "Colour")]
        public string? Colour { get; set; }

        [Display(Name = "Serial Number")]
        public string? SerialNumber { get; set; }

        [Display(Name = "Height")]
        public string? Height { get; set; }

        [Display(Name = "Size")]
        public string? Size { get; set; }

        [Display(Name = "Voltage")]
        public string? Voltage { get; set; }

        [Display(Name = "Diameter")]
        public string? Diameter { get; set; }

        [Display(Name = "Length")]
        public string? Length { get; set; }

        [Display(Name = "Batch Code")]
        public string? BatchCode { get; set; }

        [Display(Name = "Number Recovered")]
        public string? NumberRecovered { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Text Search")]
        public string? textSearch { get; set; }

        [Display(Name = "Flag")]
        public string? flag { get; set; }

        [Display(Name = "Table Name")]
        public string? tableName { get; set; }
    }
}

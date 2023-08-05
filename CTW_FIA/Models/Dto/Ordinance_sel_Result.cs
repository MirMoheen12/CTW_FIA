using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class Ordinance_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Int ID")]
        public string? intID { get; set; }

        [Display(Name = "Category")]
        public string? Category { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Other")]
        public string? Other { get; set; }

        [Display(Name = "Manufacturer")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Brand Name")]
        public string? BrandName { get; set; }

        [Display(Name = "Country Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Country Recovered")]
        public string? CountryRecovered { get; set; }

        [Display(Name = "Explosive Weight")]
        public string? ExplosiveWeight { get; set; }

        [Display(Name = "Mem Markings")]
        public string? memMarkings { get; set; }

        [Display(Name = "Batch Code")]
        public string? BatchCode { get; set; }

        [Display(Name = "Serial Numbers")]
        public string? SerialNumbers { get; set; }

        [Display(Name = "Colour")]
        public string? Colour { get; set; }

        [Display(Name = "Calibre")]
        public string? Calibre { get; set; }

        [Display(Name = "Head Stamp")]
        public string? HeadStamp { get; set; }

        [Display(Name = "Length")]
        public string? Length { get; set; }

        [Display(Name = "Width")]
        public string? Width { get; set; }

        [Display(Name = "Depth")]
        public string? Depth { get; set; }

        [Display(Name = "Diameter")]
        public string? Diameter { get; set; }

        [Display(Name = "Number Recovered")]
        public string? NumberRecovered { get; set; }

        [Display(Name = "Remarks")]
        public string? Remarks { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }
    }
}

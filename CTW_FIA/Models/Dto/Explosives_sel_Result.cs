using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class Explosives_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Category")]
        public string? dgvCategory { get; set; }

        [Display(Name = "Type")]
        public string? dgvType { get; set; }

        [Display(Name = "Quantity")]
        public string? dgvQuantity { get; set; }

        [Display(Name = "Date Sent")]
        public string? DateSent { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Measurement Unit")]
        public string? MeasurementUnit { get; set; }

        [Display(Name = "Brand Name")]
        public string? BrandName { get; set; }

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

        [Display(Name = "Packaging")]
        public string? Packaging { get; set; }

        [Display(Name = "Explosive Length")]
        public string? ExplosiveLength { get; set; }

        [Display(Name = "Explosive Width")]
        public string? ExplosiveWidth { get; set; }

        [Display(Name = "Explosive Height")]
        public string? ExplosiveHeight { get; set; }

        [Display(Name = "Sent Date")]
        public string? dteSent { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Explosive Diameter")]
        public string? ExplosiveDiameter { get; set; }

        [Display(Name = "Explosive Weight")]
        public string? ExplosiveWeight { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class Firearms_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "URN")]
        public string? strURN { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Make")]
        public string? Make { get; set; }

        [Display(Name = "Model")]
        public string? Model { get; set; }

        [Display(Name = "Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Country of Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Country Recovered")]
        public string? CountryRecovered { get; set; }

        [Display(Name = "Serial Number")]
        public string? SerialNumber { get; set; }

        [Display(Name = "Importer")]
        public string? Impoter { get; set; }

        [Display(Name = "Serial Erased")]
        public string? SerialErased { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Action")]
        public string? Action { get; set; }

        [Display(Name = "Calibre")]
        public string? Calibre { get; set; }

        [Display(Name = "Quantity")]
        public string? Quantity { get; set; }

        [Display(Name = "Barrel Length")]
        public string? BarrelLength { get; set; }

        [Display(Name = "Rounds Held")]
        public string? RoundsHeld { get; set; }

        [Display(Name = "Deactivated")]
        public string? Deactivated { get; set; }

        [Display(Name = "Reactivated")]
        public string? Reactivated { get; set; }

        [Display(Name = "Factory Made")]
        public string? FactoryMade { get; set; }

        [Display(Name = "Imitation")]
        public string? Imitation { get; set; }

        [Display(Name = "Owner's Certificate Number")]
        public string? OwnersCertificateNumber { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }
    }
}

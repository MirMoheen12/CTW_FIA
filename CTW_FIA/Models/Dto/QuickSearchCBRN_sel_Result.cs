using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchCBRN_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Int ID")]
        public string? intID { get; set; }

        [Display(Name = "Category")]
        public string? strCategory { get; set; }

        [Display(Name = "Type")]
        public string? strType { get; set; }

        [Display(Name = "Other")]
        public string? strOther { get; set; }

        [Display(Name = "Manufacturer")]
        public string? strManufacturer { get; set; }

        [Display(Name = "Name")]
        public string? strName { get; set; }

        [Display(Name = "Country Origin")]
        public string? strCountryOrigin { get; set; }

        [Display(Name = "Country Recovered")]
        public string? strCountryRecovered { get; set; }

        [Display(Name = "Quantity")]
        public string? intQuantity { get; set; }

        [Display(Name = "Quantity Measurement")]
        public string? strQuantityMeasurement { get; set; }

        [Display(Name = "Method Delivery")]
        public string? strMethodDelivery { get; set; }

        [Display(Name = "Special Precautions")]
        public string? strSpecialPrecautions { get; set; }

        [Display(Name = "Hazard")]
        public string? strHazard { get; set; }

        [Display(Name = "UN Number")]
        public string? strUNNumber { get; set; }

        [Display(Name = "Description")]
        public string? strDescription { get; set; }

        [Display(Name = "Mem Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Primary Media Image URN")]
        public string? strPrimaryMediaImageUrn { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

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

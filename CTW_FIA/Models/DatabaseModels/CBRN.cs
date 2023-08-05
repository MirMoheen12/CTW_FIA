using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CTW_FIA.Models.DatabaseModels
{
    public class CBRN
    {
        [Key]
        public string strURN { get; set; }
        public string strCountryOrigin { get; set; }
        public string strType { get; set; }
        public string strQuantityMeasurement { get; set; }
        public string strMethodDelivery { get; set; }
        public string strManufacturer { get; set; }
        public string strCountryRecovered { get; set; }
        public string strUNNumber { get; set; }
        public string strSpecialPrecautions { get; set; }
        public string strOther { get; set; }
        public string strSecurityRating { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string strHazard { get; set; }
        public string strName { get; set; }
        public string strPrimaryMediaImageUrn { get; set; }
        public int intQuantity { get; set; }
        public string memRemarks { get; set; }
        public string strCategory { get; set; }
        public string strDescription { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

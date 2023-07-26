using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class tblCNIC
    {
        [Key]
        public int intID { get; set; }
        public string strURN { get; set; }
        public string strCNIC { get; set; }
        public string strCountry { get; set; }
        public double? optOld { get; set; }
        public string strLegacyCode { get; set; }
        public string strPrimaryMediaImageUrn { get; set; }
        public double? optLibrary { get; set; }
        public double? optTransmit { get; set; }
        public string memRemarks { get; set; }
        public string excl_memTextSearch { get; set; }
        public double? optCompliance { get; set; }
        public string strSecurityRating { get; set; }
        public string strCreatedBy { get; set; }
        public DateTime? dteCreated { get; set; }
        public DateTime? dteSent { get; set; }
        public DateTime? dteLastModified { get; set; }
        public string strLastModifiedBy { get; set; }
    }

}

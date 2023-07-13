namespace CTW_FIA.Models.DatabaseModels
{
    public class tblPassport
    {
        public int intID { get; set; }
        public string strURN { get; set; }
        public string strPassportNo { get; set; }
        public string strCountry { get; set; }
        public DateTime? dteIssue { get; set; }
        public string strPlaceIssue { get; set; }
        public DateTime? dteExpire { get; set; }
        public string strLegacyCode { get; set; }
        public string strPrimaryMediaImageUrn { get; set; }
        public bool? optLibrary { get; set; }
        public bool? optTransmit { get; set; }
        public string memRemarks { get; set; }
        public string excl_memTextSearch { get; set; }
        public bool? optCompliance { get; set; }
        public string strSecurityRating { get; set; }
        public string strCreatedBy { get; set; }
        public DateTime? dteCreated { get; set; }
        public DateTime? dteSent { get; set; }
        public DateTime? dteLastModified { get; set; }
        public string strLastModifiedBy { get; set; }
    }

}

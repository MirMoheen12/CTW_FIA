namespace CTW_FIA.Models.DatabaseModels
{
    public class tblMedia
    {
        public int intID { get; set; }
        public string strURN { get; set; }
        public string strTitle { get; set; }
        public string strFilename { get; set; }
        public string strSource { get; set; }
        public DateTime? dteDateTaken { get; set; }
        public double? intLatitude { get; set; }
        public double? intLongitude { get; set; }
        public int? intHeight { get; set; }
        public int? intWidth { get; set; }
        public int? intSize { get; set; }
        public string strPrimaryMediaImageUrn { get; set; }
        public string strTitleMeta { get; set; }
        public string strAuthorMeta { get; set; }
        public string strCompanyMeta { get; set; }
        public string strComputerMeta { get; set; }
        public DateTime? dteCreatedMeta { get; set; }
        public DateTime? dteLastModifiedMeta { get; set; }
        public string memAdditionalDetails { get; set; }
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
        public int? intFolderID { get; set; }
    }

}

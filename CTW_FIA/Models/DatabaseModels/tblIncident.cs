namespace CTW_FIA.Models.DatabaseModels
{
    public class tblIncident
    {
        public int intID { get; set; }
        public string strURN { get; set; }
        public string strOperationName { get; set; }
        public DateTime? dteIncidentDate { get; set; }
        public DateTime? dteIncidentTime { get; set; }
        public DateTime? dteIncidentTimeEnd { get; set; }
        public string strAddress { get; set; }
        public string strCityTownProvince { get; set; }
        public string strCountyState { get; set; }
        public string strPostalZip { get; set; }
        public string strCommonwealthTerritory { get; set; }
        public string strCountry { get; set; }
        public double? intLatitude { get; set; }
        public double? intLongitude { get; set; }
        public string strCaseFileRefNumber { get; set; }
        public string strDeliveryMethod { get; set; }
        public string strTarget { get; set; }
        public string strMotive { get; set; }
        public string strIncidentCategory { get; set; }
        public string strOther { get; set; }
        public bool? optRecovered { get; set; }
        public string strPreIncidentThreat { get; set; }
        public string strPostIncidentThreat { get; set; }
        public int? intNumberKilled { get; set; }
        public int? intNumberInjured { get; set; }
        public int? intNumberArrested { get; set; }
        public string strPrimaryMediaImageUrn { get; set; }
        public string strLegacyCode { get; set; }
        public DateTime? dteIncidentDateWeekStart { get; set; }
        public DateTime? dteIncidentDateWeekEnd { get; set; }
        public int? intIncidentDay { get; set; }
        public string strDistrict { get; set; }
        public string strTargettedPersons { get; set; }
        public string strLatestCaseProgress { get; set; }
        public string strAdditionalRemarks { get; set; }
        public string strFirNo { get; set; }
        public string strCasualtiesNames { get; set; }
        public string strInjuredNames { get; set; }
        public string strRoleOfSig { get; set; }
        public int? intIncidentMonth { get; set; }
        public int? intIncidentYear { get; set; }
        public string strTargetDescription { get; set; }
        public string strSubTargetName { get; set; }
        public string strWeaponName { get; set; }
        public string strMotiveDescription { get; set; }
        public int? intSubTarget { get; set; }
        public int? intSuicideBorne { get; set; }
        public string strCaseStatus { get; set; }
        public string strMilitaryWeaponType { get; set; }
        public string strTimeZone { get; set; }
        public int? intTimeOffset { get; set; }
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
        public bool? optSuicideBorne { get; set; }
        public string memRecoveries { get; set; }
    }

}

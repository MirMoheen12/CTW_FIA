namespace CTW_FIA.Models.DatabaseModels
{
    public class Chemical
    {
        public string strURN { get; set; }
        public string Name { get; set; }
        public string OtherNames { get; set; }
        public string CountryRecovered { get; set; }
        public string CountryOrigin { get; set; }
        public string CasNo { get; set; }
        public string RtecsNo { get; set; }
        public string UnNo { get; set; }
        public string EcNo { get; set; }
        public string ChemicalFormula { get; set; }
        public string PhysicalAppearance { get; set; }
        public string ChemicalDangers { get; set; }
        public string OccupationalExposureLimitsTLV { get; set; }
        public string OccupationalExposureLimitsMAK { get; set; }
        public string RoutesOfExposure { get; set; }
        public string SpillageDisposal { get; set; }
        public string Packaging { get; set; }
        public string Labelling { get; set; }
        public string SafeStorage { get; set; }
        public string TransportEmergencyCard { get; set; }
        public string NfpaCode { get; set; }
        public string UnHazardClass { get; set; }
        public string UnSubsidiaryRisks { get; set; }
        public string UnPackGroup { get; set; }
        public string HazardExposure { get; set; }
        public string BoilingPointLow { get; set; }
        public string BoilingPointHigh { get; set; }
        public string MeltingPointHighLow { get; set; }
        public string MeltingPointHigh { get; set; }
        public string DensityLow { get; set; }
        public string DensityHigh { get; set; }
        public string RelativeDensityLow { get; set; }
        public string RelativeDensityHigh { get; set; }
        public string WaterSolubility { get; set; }
        public string VapourPressureLow { get; set; }
        public string VapourPressureHigh { get; set; }
        public string RelativeVapourDensityLow { get; set; }
        public string RelativeVapourDensityHigh { get; set; }
        public string FlashPointLow { get; set; }
        public string FlashPointHigh { get; set; }
        public string AutoIgnitionTempLow { get; set; }
        public string AutoIgnitionTempHigh { get; set; }
        public string ExplosiveLimits { get; set; }
        public string OctanolWaterPartitionLow { get; set; }
        public string OctanolWaterPartitionHigh { get; set; }
        public string InhalationRisk { get; set; }
        public string EnvironmentalData { get; set; }
        public string memRemarks { get; set; }
        public DateTime dteSent { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

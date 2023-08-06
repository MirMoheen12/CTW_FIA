using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchChemicals_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Int ID")]
        public string? intID { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Other Names")]
        public string? OtherNames { get; set; }

        [Display(Name = "Country Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Country Recovered")]
        public string? CountryRecovered { get; set; }

        [Display(Name = "CAS No")]
        public string? CasNo { get; set; }

        [Display(Name = "RTECS No")]
        public string? RtecsNo { get; set; }

        [Display(Name = "UN No")]
        public string? UnNo { get; set; }

        [Display(Name = "EC No")]
        public string? EcNo { get; set; }

        [Display(Name = "Chemical Formula")]
        public string? ChemicalFormula { get; set; }

        [Display(Name = "Physical Appearance")]
        public string? PhysicalAppearance { get; set; }

        [Display(Name = "Chemical Dangers")]
        public string? ChemicalDangers { get; set; }

        [Display(Name = "Routes of Exposure")]
        public string? RoutesOfExposure { get; set; }

        [Display(Name = "Occupational Exposure Limits (MAK)")]
        public string? OccupationalExposureLimitsMAK { get; set; }

        [Display(Name = "Occupational Exposure Limits (TLV)")]
        public string? OccupationalExposureLimitsTLV { get; set; }

        [Display(Name = "Spillage Disposal")]
        public string? SpillageDisposal { get; set; }

        [Display(Name = "Packaging")]
        public string? Packaging { get; set; }

        [Display(Name = "Labelling")]
        public string? Labelling { get; set; }

        [Display(Name = "Safe Storage")]
        public string? SafeStorage { get; set; }

        [Display(Name = "Transport Emergency Card")]
        public string? TransportEmergencyCard { get; set; }

        [Display(Name = "NFPA Code")]
        public string? NfpaCode { get; set; }

        [Display(Name = "UN Hazard Class")]
        public string? UnHazardClass { get; set; }

        [Display(Name = "UN Subsidiary Risks")]
        public string? UnSubsidiaryRisks { get; set; }

        [Display(Name = "UN Pack Group")]
        public string? UnPackGroup { get; set; }

        [Display(Name = "Hazard Exposure")]
        public string? HazardExposure { get; set; }

        [Display(Name = "Boiling Point (High)")]
        public string? BoilingPointHigh { get; set; }

        [Display(Name = "Boiling Point (Low)")]
        public string? BoilingPointLow { get; set; }

        [Display(Name = "Melting Point (High)")]
        public string? MeltingPointHigh { get; set; }

        [Display(Name = "Melting Point (High-Low)")]
        public string? MeltingPointHighLow { get; set; }

        [Display(Name = "Density (High)")]
        public string? DensityHigh { get; set; }

        [Display(Name = "Density (Low)")]
        public string? DensityLow { get; set; }

        [Display(Name = "Relative Density (High)")]
        public string? RelativeDensityHigh { get; set; }

        [Display(Name = "Relative Density (Low)")]
        public string? RelativeDensityLow { get; set; }

        [Display(Name = "Water Solubility")]
        public string? WaterSolubility { get; set; }

        [Display(Name = "Vapour Pressure (High)")]
        public string? VapourPressureHigh { get; set; }

        [Display(Name = "Vapour Pressure (Low)")]
        public string? VapourPressureLow { get; set; }

        [Display(Name = "Relative Vapour Density (High)")]
        public string? RelativeVapourDensityHigh { get; set; }

        [Display(Name = "Relative Vapour Density (Low)")]
        public string? RelativeVapourDensityLow { get; set; }

        [Display(Name = "Flash Point (High)")]
        public string? FlashPointHigh { get; set; }

        [Display(Name = "Flash Point (Low)")]
        public string? FlashPointLow { get; set; }

        [Display(Name = "Auto-Ignition Temp (High)")]
        public string? AutoIgnitionTempHigh { get; set; }

        [Display(Name = "Auto-Ignition Temp (Low)")]
        public string? AutoIgnitionTempLow { get; set; }

        [Display(Name = "Explosive Limits")]
        public string? ExplosiveLimits { get; set; }

        [Display(Name = "Octanol/Water Partition (Low)")]
        public string? OctanolWaterPartitionLow { get; set; }

        [Display(Name = "Inhalation Risk")]
        public string? InhalationRisk { get; set; }

        [Display(Name = "Environmental Data")]
        public string? EnvironmentalData { get; set; }

        [Display(Name = "Mem Remarks")]
        public string? memRemarks { get; set; }

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

namespace CTW_FIA.Models.DatabaseModels
{
    public class Detonator
    {
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public int Quantity { get; set; }
        public string CountryOfRecovery { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CapMaterial { get; set; }
        public string CapColor { get; set; }
        public decimal CapLength { get; set; }
        public decimal CapDiameter { get; set; }
        public string Crimp { get; set; }
        public string CrimpType { get; set; }
        public string PlugColor { get; set; }
        public string PlugMaterial { get; set; }
        public string WireColor { get; set; }
        public string WireColor2 { get; set; }
        public decimal WireDiameter { get; set; }
        public string WireMaterial { get; set; }
        public string CaseTubeMaterial { get; set; }
        public string CaseTubeColor { get; set; }
        public decimal CaseTubeLength { get; set; }
        public decimal CaseTubeDiameter { get; set; }
        public string BaseShape { get; set; }
        public string BaseMarking { get; set; }
        public string BatchCode { get; set; }
        public string MemRemarks { get; set; }
        public DateTime StrDateEstablished { get; set; }
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

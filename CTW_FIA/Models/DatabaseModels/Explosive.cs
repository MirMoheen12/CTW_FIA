namespace CTW_FIA.Models.DatabaseModels
{
    public class Explosive
    {
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string MeasurementUnit { get; set; }
        public string BrandName { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOrigin { get; set; }
        public string CountryRecovered { get; set; }
        public string Markings { get; set; }
        public string Colour { get; set; }
        public string Packaging { get; set; }
        public double ExplosiveLength { get; set; }
        public double ExplosiveWidth { get; set; }
        public double ExplosiveHeight { get; set; }
        public double ExplosiveWeight { get; set; }
        public double ExplosiveDiameter { get; set; }
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

namespace CTW_FIA.Models.DatabaseModels
{
    public class Pipe
    {
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public string Manufacturer { get; set; }
        public string BrandName { get; set; }
        public string strCountryRecovered { get; set; }
        public string strCountryOrigin { get; set; }
        public string ExplosiveWeight { get; set; }
        public string memMarkings { get; set; }
        public string BatchCode { get; set; }
        public string Components { get; set; }
        public string ECMaterial { get; set; }
        public string ECManufacturer { get; set; }
        public string ECCountryOrigin { get; set; }
        public string ECLength { get; set; }
        public string ECDiameter { get; set; }
        public string ECMarkings { get; set; }
        public string ECQuantity { get; set; }
        public string MemRemarks { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }

}

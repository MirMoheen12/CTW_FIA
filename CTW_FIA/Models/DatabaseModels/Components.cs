namespace CTW_FIA.Models.DatabaseModels
{
    public class Components
    {
        public string strURN { get; set; }
        public string Type { get; set; }
        public string CountryOrigin { get; set; }
        public string Material { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string MethodDelivery { get; set; }
        public string QuantityWeight { get; set; }
        public string QuantityNo { get; set; }
        public string CountryRecovered { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Diameter { get; set; }
        public string Colour { get; set; }
        public string Markings { get; set; }
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

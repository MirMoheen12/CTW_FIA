namespace CTW_FIA.Models
{
    public class Property
    {
        public string StrURN { get; set; }
        public string PropertyName { get; set; }
        public decimal PropertyValue { get; set; }
        public string Currency { get; set; }
        public string Addresses { get; set; }
        public string MemRemarks { get; set; }
        public int IntID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string TextSearch { get; set; }
        public int Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
        public string Category { get; set; }
    }

}

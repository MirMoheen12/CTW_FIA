namespace CTW_FIA.Models.DatabaseModels
{
    public class BankAccount
    {
        public string strURN { get; set; }
        public string AccountNo { get; set; }
        public string BranchCode { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string MemRemarks { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
        public string AccountTitle { get; set; }
    }

}

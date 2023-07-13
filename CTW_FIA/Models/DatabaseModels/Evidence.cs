namespace CTW_FIA.Models.DatabaseModels
{
    public class Evidence
    {
        public string strURN { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string CollectedBy { get; set; }
        public string Location { get; set; }
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
        public string OfficerName { get; set; }
        public string Designation { get; set; }
        public string DepartmentName { get; set; }
    }

}

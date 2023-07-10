namespace CTW_FIA.Models.DatabaseModels
{
    public class Communications
    {
        public string strURN { get; set; }
        public string CommType { get; set; }
        public string CommDescription { get; set; }
        public string CommName { get; set; }
        public string Other { get; set; }
        public string WebValue { get; set; }
        public string Number { get; set; }
        public string ServiceProvider { get; set; }
        public string CountryOrigin { get; set; }
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

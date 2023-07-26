using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Group
    {
        [Key]
        public string strURN { get; set; }
        public string GroupName { get; set; }
        public string SubCategory { get; set; }
        public string CountryOrigin { get; set; }
        public string GroupTo { get; set; }
        public string HeadName { get; set; }
        public string MemGoals { get; set; }
        public string strDeclaredByWhom { get; set; }
        public int Strength { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalZip { get; set; }
        public string Address { get; set; }
        public string MemRemarks { get; set; }
        public DateTime DateEstablished { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string GroupReportingAgency { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

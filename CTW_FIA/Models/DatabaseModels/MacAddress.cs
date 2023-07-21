using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class MacAddress
    {
        [Key]
        public int intID { get; set; }
        public string strURN { get; set; }
        public string MAC_Address { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> OfficeID { get; set; }
        public string ComputerName { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    }

}

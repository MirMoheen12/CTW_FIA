using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class IpLogs
    {
        [Key]
        public string strURN { get; set; }
        public string IP { get; set; }
        public string UserId { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }

}

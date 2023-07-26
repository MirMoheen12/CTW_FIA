using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class DatabaseList
    {
        [Key]
        public string strURN { get; set; }
        public int intType { get; set; }
        public string strTitle { get; set; }
        public string strTable { get; set; }
        public string strTranslation { get; set; }
        public bool optTransmit { get; set; }
        public bool optPhysicalDatabase { get; set; }
        public DateTime dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string strControllerName { get; set; }
    }

}

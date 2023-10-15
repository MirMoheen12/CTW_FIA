using System.ComponentModel.DataAnnotations;
namespace CTW_FIA.Models.DatabaseModels
{
    public class AccusationStatusList
    {
        [Key]
        public int IntID { get; set; }
        public int AccusationStatus_ID { get; set; }
        public string AccusationStatus_Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}

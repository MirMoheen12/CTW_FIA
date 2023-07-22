using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class BaseLogs
    {
        [Key]
        public int Id { get; set; }
        public string strURN { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string textSearch { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class CommonLinks
    {
        [Key]
        public string strURN { get; set; }
        public string strURNDest { get; set; }
        public string strURNSource { get; set; }
        public string strLink { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string InformationEvaluation { get; set; }
        public string SourceEvaluation { get; set; }
        public int intDbIdDest { get; set; }
        public int intDbIdSource { get; set; }
        public bool optBiDirectional { get; set; }
        public string textSearch { get; set; }
    }

}

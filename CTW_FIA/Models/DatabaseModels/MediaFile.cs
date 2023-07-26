using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class MediaFile
    {
        [Key]
        public string strURN { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string FilePath { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }

}

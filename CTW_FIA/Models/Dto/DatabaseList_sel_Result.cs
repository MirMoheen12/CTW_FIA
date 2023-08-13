using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class DatabaseList_sel_Result
    {
        public string? SerialNo { get; set; }
        
        [DisplayName("Str URN")]
        public string? strURN { get; set; }
        public string? intID { get; set; }
        public string? intType { get; set; }
        public string? strTitle { get; set; }
        public string? strTable { get; set; }
        public string? strControllerName { get; set; }
        public string? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
    }
}

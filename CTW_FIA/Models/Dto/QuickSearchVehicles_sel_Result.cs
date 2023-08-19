using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchVehicles_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "str URN")]
        public string? strURN { get; set; }

        [Display(Name = "int ID")]
        public string? intID { get; set; }

        [Display(Name = "Vehicle Type")]
        public string? VehicleType { get; set; }

        [Display(Name = "Vehicle SubType")]
        public string? VehicleSubType { get; set; }

        [Display(Name = "Make Model")]
        public string? MakeModel { get; set; }

        [Display(Name = "Registration No")]
        public string? RegistrationNo { get; set; }

        [Display(Name = "Chases No")]
        public string? ChasesNo { get; set; }

        [Display(Name = "Color")]
        public string? Color { get; set; }

        [Display(Name = "Size")]
        public string? Size { get; set; }

        [Display(Name = "Device Location")]
        public string? DeviceLocation { get; set; }

        [Display(Name = "memRemarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "dteSent")]
        public string? dteSent { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "textSearch")]
        public string? textSearch { get; set; }

        [Display(Name = "flag")]
        public string? flag { get; set; }

        [Display(Name = "tableName")]
        public string? tableName { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }
    }
}

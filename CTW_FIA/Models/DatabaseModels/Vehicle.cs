using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Vehicle
    {
        [Key]
        public string strURN { get; set; }
        public string VehicleType { get; set; }
        public string VehicleSubType { get; set; }
        public string MakeModel { get; set; }
        public string RegistrationNo { get; set; }
        public string ChasesNo { get; set; }
        public string Color { get; set; }
        public string size { get; set; }
        public string DeviceLocation { get; set; }
        public string memRemarks { get; set; }
        public DateTime? dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public int? Status { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

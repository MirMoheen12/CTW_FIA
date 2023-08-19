using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{

    public class Firearms
    {
        [Key]
        public string strURN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CountryOrigin { get; set; }
        public string Impoter { get; set; }
        public string SerialNumber { get; set; }
        public string SerialErased { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string Calibre { get; set; }
        public int Quantity { get; set; }
        public string CountryRecovered { get; set; }
        public decimal BarrelLength { get; set; }
        public int RoundsHeld { get; set; }
        public DateTime Deactivated { get; set; }
        public DateTime Reactivated { get; set; }
        public bool FactoryMade { get; set; }
        public bool Imitation { get; set; }
        public string OwnersCertificateNumber { get; set; }
        public string memRemarks { get; set; }
        public DateTime dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }




}

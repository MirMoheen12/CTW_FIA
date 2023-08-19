using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CTW_FIA.Models.DatabaseModels
{
    public class Components
    {
        [Key]
        public string strURN { get; set; }
        public string Type { get; set; }
        public string CountryOrigin { get; set; }
        public string Material { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string MethodDelivery { get; set; }
        public Nullable<float> QuantityWeight { get; set; }
        public Nullable<float> QuantityNo { get; set; }
        public string CountryRecovered { get; set; }
        public Nullable<float> Length { get; set; }
        public Nullable<float> Width { get; set; }
        public Nullable<float> Height { get; set; }
        public Nullable<float> Diameter { get; set; }
        public string Colour { get; set; }
        public string Markings { get; set; }
        public string memRemarks { get; set; }
        public Nullable<System.DateTime> dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

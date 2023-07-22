using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public partial class Address
    {
        [Key]
        public string strURN { get; set; }
        public string AddressDescription { get; set; }
        public string AddressName { get; set; }
        public string AddressType { get; set; }
        public Nullable<int> HouseNumber { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public Nullable<int> StreetNumber { get; set; }
        public string Mohallah { get; set; }
        public string Village { get; set; }
        public string Town { get; set; }
        public string PostOffice { get; set; }
        public string TehsilTaluka { get; set; }
        public string PostalZip { get; set; }
        public string CommonwealthTerritory { get; set; }
        public Nullable<float> Latitude { get; set; }
        public Nullable<float> Longitude { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }
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

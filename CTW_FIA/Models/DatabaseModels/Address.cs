namespace CTW_FIA.Models.DatabaseModels
{
    public class Address
    {
        public string StrURN { get; set; }
        public string AddressDescription { get; set; }
        public string AddressName { get; set; }
        public string AddressType { get; set; }
        public string HouseNumber { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string StreetNumber { get; set; }
        public string Mohallah { get; set; }
        public string Village { get; set; }
        public string Town { get; set; }
        public string PostOffice { get; set; }
        public string TehsilTaluka { get; set; }
        public string PostalZip { get; set; }
        public string CommonwealthTerritory { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }
        public string MemRemarks { get; set; }
        public DateTime DteSent { get; set; }
        public int IntID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string TextSearch { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class QuickSearchAddress_sel
    {
      
            [Display(Name = "Serial Number")]
            public string? SerialNo { get; set; }

            [Display(Name = "URN")]
            public string? strURN { get; set; }

            [Display(Name = "ID")]
            public string? intID { get; set; }

            [Display(Name = "Address Description")]
            public string? AddressDescription { get; set; }

            [Display(Name = "Address Name")]
            public string? AddressName { get; set; }

            [Display(Name = "Address Type")]
            public string? AddressType { get; set; }

            [Display(Name = "Country")]
            public string? Country { get; set; }

            [Display(Name = "Province")]
            public string? Province { get; set; }

            [Display(Name = "District")]
            public string? District { get; set; }

            [Display(Name = "City")]
            public string? City { get; set; }

            [Display(Name = "Postal/Zip Code")]
            public string? PostalZip { get; set; }

            [Display(Name = "Remarks")]
            public string? memRemarks { get; set; }

            [Display(Name = "Is Deleted")]
            public string? IsDeleted { get; set; }

            [Display(Name = "Created On")]
            public string? CreatedOn { get; set; }

            [Display(Name = "Created By")]
            public string? CreatedBy { get; set; }

            [Display(Name = "Updated On")]
            public string? UpdatedOn { get; set; }

            [Display(Name = "Updated By")]
            public string? UpdatedBy { get; set; }

            [Display(Name = "Text Search")]
            public string? textSearch { get; set; }

            [Display(Name = "Flag")]
            public string? flag { get; set; }

            [Display(Name = "Table Name")]
            public string? tableName { get; set; }

            [Display(Name = "Street Number")]
            public string? StreetNumber { get; set; }

            [Display(Name = "Mohallah")]
            public string? Mohallah { get; set; }

            [Display(Name = "Village")]
            public string? Village { get; set; }

            [Display(Name = "Town")]
            public string? Town { get; set; }

            [Display(Name = "Post Office")]
            public string? PostOffice { get; set; }

            [Display(Name = "Tehsil/Taluka")]
            public string? TehsilTaluka { get; set; }

            [Display(Name = "Commonwealth Territory")]
            public string? CommonwealthTerritory { get; set; }

            [Display(Name = "Other1")]
            public string? Other1 { get; set; }

            [Display(Name = "Other2")]
            public string? Other2 { get; set; }

            [Display(Name = "House Number")]
            public string? HouseNumber { get; set; }
        }

    }


using System.ComponentModel.DataAnnotations;
namespace CTW_FIA.Models.Dto

{
    using System;
    using System.ComponentModel;

    public class Components_sel_Result
    {
        public string? SerialNo { get; set; }

        [DisplayName("Str URN")]
        public string? strURN { get; set; }
        public string? intID { get; set; }
        public string? Type { get; set; }
        public string? CountryOrigin { get; set; }
        public string? Material { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; }
        public string? MethodDelivery { get; set; }
        public string? QuantityWeight { get; set; }
        public string? QuantityNo { get; set; }
        public string? CountryRecovered { get; set; }
        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? Diameter { get; set; }
        public string? Colour { get; set; }
        public string? Markings { get; set; }
        public string? memRemarks { get; set; }
        public string? IsDeleted { get; set; }
        public string? CreatedOn { get; set; }
    }
}

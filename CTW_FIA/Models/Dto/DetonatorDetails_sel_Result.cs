using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class DetonatorDetails_sel_Result
    {
        [DisplayName("Serial Number")]
        public string? SerialNo { get; set; }

        [DisplayName("URN")]
        public string? strURN { get; set; }

        [DisplayName("ID")]
        public string? intID { get; set; }

        [DisplayName("Category")]
        public string? Category { get; set; }

        [DisplayName("Type")]
        public string? Type { get; set; }

        [DisplayName("Other")]
        public string? Other { get; set; }

        [DisplayName("Quantity")]
        public string? Quantity { get; set; }

        [DisplayName("Manufacturer")]
        public string? Manufacturer { get; set; }

        [DisplayName("Country of Origin")]
        public string? CountryOfOrigin { get; set; }

        [DisplayName("Country of Recovery")]
        public string? CountryOfRecovery { get; set; }

        [DisplayName("Brand")]
        public string? Brand { get; set; }

        [DisplayName("Model")]
        public string? Model { get; set; }

        [DisplayName("Cap Material")]
        public string? CapMaterial { get; set; }

        [DisplayName("Cap Color")]
        public string? CapColor { get; set; }

        [DisplayName("Cap Length")]
        public string? CapLength { get; set; }

        [DisplayName("Cap Diameter")]
        public string? CapDiameter { get; set; }

        [DisplayName("Crimp")]
        public string? Crimp { get; set; }

        [DisplayName("Crimp Type")]
        public string? CrimpType { get; set; }

        [DisplayName("Plug Color")]
        public string? PlugColor { get; set; }

        [DisplayName("Plug Material")]
        public string? PlugMaterial { get; set; }

        [DisplayName("Wire Color")]
        public string? WireColor { get; set; }

        [DisplayName("Wire Color 2")]
        public string? WireColor2 { get; set; }

        [DisplayName("Wire Diameter")]
        public string? WireDiameter { get; set; }

        [DisplayName("Wire Material")]
        public string? WireMaterial { get; set; }

        [DisplayName("Case Tube Material")]
        public string? CaseTubeMaterial { get; set; }

        [DisplayName("Case Tube Color")]
        public string? CaseTubeColor { get; set; }

        [DisplayName("Case Tube Length")]
        public string? CaseTubeLength { get; set; }

        [DisplayName("Case Tube Diameter")]
        public string? CaseTubeDiameter { get; set; }

        [DisplayName("Base Shape")]
        public string? BaseShape { get; set; }

        [DisplayName("Base Marking")]
        public string? BaseMarking { get; set; }

        [DisplayName("Batch Code")]
        public string? BatchCode { get; set; }

        [DisplayName("Remarks")]
        public string? memRemarks { get; set; }

        [DisplayName("Is Deleted")]
        public string IsDeleted { get; set; }

        [DisplayName("Created On")]
        public string? CreatedOn { get; set; }

        [DisplayName("Flag")]
        public string? flag { get; set; }

        [DisplayName("Table Name")]
        public string? tableName { get; set; }

        [DisplayName("Text Search")]
        public string? textSearch { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Detonator
    {
        [Key]
        public string strURN { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public Nullable<float> Quantity { get; set; }
        public string CountryOfRecovery { get; set; }
        public string Manufacturer { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CapMaterial { get; set; }
        public string CapColor { get; set; }
        public string CapLength { get; set; }
        public string CapDiameter { get; set; }
        public Nullable<int> Crimp { get; set; }
        public string CrimpType { get; set; }
        public string PlugColor { get; set; }
        public string PlugMaterial { get; set; }
        public string WireColor { get; set; }
        public string WireColor2 { get; set; }
        public string WireDiameter { get; set; }
        public string WireMaterial { get; set; }
        public string CaseTubeMaterial { get; set; }
        public string CaseTubeColor { get; set; }
        public Nullable<float> CaseTubeLength { get; set; }
        public Nullable<float> CaseTubeDiameter { get; set; }
        public string BaseShape { get; set; }
        public string BaseMarking { get; set; }
        public string BatchCode { get; set; }
        public string MemRemarks { get; set; }
        public Nullable<System.DateTime> StrDateEstablished { get; set; }
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

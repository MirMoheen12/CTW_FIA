namespace CTW_FIA.Models.DatabaseModels
{
    public class WeaponList
    {
        public int intID { get; set; }
        public int? Weapon_ID { get; set; }
        public string Weapon_Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? IsDeleted { get; set; }
    }

}

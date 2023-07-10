﻿namespace CTW_FIA.Models.DatabaseModels
{
    public class EquipmentDetails
    {
        public string strURN { get; set; }
        public int intID { get; set; }
        public string Category { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}

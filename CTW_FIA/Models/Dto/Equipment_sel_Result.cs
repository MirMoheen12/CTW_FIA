﻿using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class Equipment_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "URN")]
        public string? strURN { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Category")]
        public string? Category { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Manufacturer")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Serial Number")]
        public string? SerialNumber { get; set; }

        [Display(Name = "Quantity")]
        public string? Quantity { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }
    }
}

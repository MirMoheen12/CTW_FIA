﻿using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IEquipments
    {
       public bool AddNewEquipment(Equipment equ);
        public List<Equipment_sel_Result> AllEquipments();
    }
}

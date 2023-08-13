﻿using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IPowerSource
    {
        public List<PowerSource_sel_Result> AllPowerSource();
        public bool AddPowerSource(PowerSource powerSource, String WhoCreatedName);
        public PowerSource GetpowerSourceById(string id);

        public QuickSearchPowerSource_sel_Result GetPowerSourceByStrurn(String STRURN);
        void DeletePowerSource(string sTRUN);
        void EditPowerSource(string sTRUN);
    }
}

﻿using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
namespace CTW_FIA.Interface
{
    public interface IEvidence
    {
        public List<Evidence_sel_Result> AllEvidence();
        public bool AddNewEvidence(Evidence evd);

        public QuickSearchEvidence_sel_Result GetEvidenceByStrurn(string sTRUN);
        void PostEditEvidence(Evidence c);
    }
}

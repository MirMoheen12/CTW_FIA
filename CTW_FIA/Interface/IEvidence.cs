using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IEvidence
    {
        public List<Evidence> AllEvidence();
        public bool AddNewEvidence(Evidence evd);

        public Evidence GetEvidenceByStrurn(string sTRUN);
        void PostEditEvidence(Evidence c);
    }
}

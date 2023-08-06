using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IDetonators
    {
        public List<DetonatorDetails_sel_Result> alldetonators();
        public bool AddDetonators(Detonator D);
         public DetonatorDetails_sel_Result GetDetonatorsByStrurn(string sTRUN);
    }
}

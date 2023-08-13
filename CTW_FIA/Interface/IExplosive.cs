using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IExplosive
    {
        public List<Explosives_sel_Result> AllExplosive();
        public bool AddExplosive(Explosive E);
        public QuickSearchExplosives_sel_Result GetExplosiveByStrurn(String STRURN);
        void DeleteExplosives(string sTRUN);
        void EditExplosives(string sTRUN);
    }
}

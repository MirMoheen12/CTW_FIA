using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IFearams
    {
        public List<Firearms_sel_Result> allfearms();
        object GetGroupsByStrurn(string sTRUN);
    }
}

using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Interface
{
    public interface ICommonlinks
    {
        public List<GraphDto> getAlllinksCount(string StrUrn);
    }
}

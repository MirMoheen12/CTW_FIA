using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Interface
{
    public interface ICommonlinks
    {
        public List<GraphDto> getAlllinksCount(string StrUrn);
        public List<CommonLinks> GetallLinks();
        public bool CreateCommonlinks(string srcSTRURN, string dstSTRURN, string DbSrc, string DbDest, string linkType, string textsearch, string SE = "", string RE = "", string RL = "", string BI = "");
    }
}

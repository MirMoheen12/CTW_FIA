using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IAddress
    {
        public string AddAddress(Address address);
        public QuickSearchAddress_sel getAdrsByStrurn(string sTRUN);
    }
}

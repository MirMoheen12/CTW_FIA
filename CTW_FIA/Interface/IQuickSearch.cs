using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IQuickSearch
    {
        public List<QuickSearchModel> getSearchdata(string SearchValue);
    }
}

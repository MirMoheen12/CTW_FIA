using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IIncident
    {
        public List<PreviewIncident> getIncidentProvincewiese(string Province);
    }
}

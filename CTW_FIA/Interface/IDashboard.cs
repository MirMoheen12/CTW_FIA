using CTW_FIA.Models.LocalModels;

namespace CTW_FIA.Interface
{
    public interface IDashboard
    {
        public GraphCount getCtwdashboard();
        public List<GraphDto> getCtwdashboardsGraphwise();
        public List<GraphDto> getCtwdashboardsIncidentwise();

        public List<GraphDto> getCtwdashboardsterroristtwise();
        public List<GraphDto> getCtwdashboardsExplosivetwise();
    }
}

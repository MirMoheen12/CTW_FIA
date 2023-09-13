using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System.Data;

namespace CTW_FIA.Interface
{
    public interface IJson
    {
        public List<ReportingAgency> GetReportingAgencies();
        public List<DatabaseList_sel_Result> databaseLists();
        public DataTable GetRecordData(string TableName, string SearchRec, int SRowNumber,int ERowNumber);
        public List<QuickSearchRSide> Displaylist(string strURN);
    }
}

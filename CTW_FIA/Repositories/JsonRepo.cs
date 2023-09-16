using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class JsonRepo : IJson
    {
        private readonly AppDbContext appDbContext;
        private readonly IDatabaseRepo databaseRepo;
        public JsonRepo(AppDbContext appDbContext,IDatabaseRepo databaseRepo)
        {
            this.databaseRepo = databaseRepo;
            this.appDbContext = appDbContext;

        }

        public List<DatabaseList_sel_Result> databaseLists()
        {
            var dat = databaseRepo.ExecuteProc("DatabaseList_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(DatabaseList_sel_Result));
            return res.Cast<DatabaseList_sel_Result>().ToList();
        }

        public List<ReportingAgency> GetReportingAgencies()
        {
            var data = appDbContext.ReportingAgency.ToList();
            return data;
        }
        public DataTable GetRecordData(string TableName, string SearchRec, int SRowNumber, int ERowNumber, string? Province)
        {
            if (Province == null)
            {
                var data = new
                {
                    TableName = TableName,
                    SearchRec = SearchRec,
                    StartRowNumber = SRowNumber,
                    EndRowNumber = ERowNumber
                };
                var dat = databaseRepo.ExecuteProc("GetRecords", databaseRepo.returnSppram(data));
                return dat;
            }
            else
            {
                if (TableName == "Incident")
                {
                    var data = new
                    {
                        TableName = TableName,
                        SearchRec = SearchRec,
                        StartRowNumber = SRowNumber,
                        EndRowNumber = ERowNumber,
                        Province = Province
                    };
                    var dat = databaseRepo.ExecuteProc("GetRecordswihtProvince", databaseRepo.returnSppram(data));
                    return dat;
                }
                else if (TableName == "Person")
                {
                    var data = new
                    {
                        TableName = TableName,
                        SearchRec = SearchRec,
                        StartRowNumber = SRowNumber,
                        EndRowNumber = ERowNumber,
                        Province = Province
                    };
                    var dat = databaseRepo.ExecuteProc("GetRecordswihtProvincePerson", databaseRepo.returnSppram(data));
                    return dat;
                }
                return null;
           
            }
        }

        public List<QuickSearchRSide> Displaylist(string strURN)
        {
            var data = new
            {
                StrURn = strURN
            };
            var dat = databaseRepo.ExecuteProc("getRightNavlink", databaseRepo.returnSppram(data));
            var res = databaseRepo.ConverttoObject(dat, typeof(QuickSearchRSide));
            return res.Cast<QuickSearchRSide>().ToList();
            
        }
    }
}
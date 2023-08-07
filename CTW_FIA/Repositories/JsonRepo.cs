﻿using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
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
        public DataTable GetRecordData(string TableName,string SearchRec,int RowNumber)
        {
            var data = new
            {
                TableName = TableName,
                SearchRec = SearchRec,
                RowNumber = RowNumber
            };
            var dat = databaseRepo.ExecuteProc("GetRecords", databaseRepo.returnSppram(data));
            return dat;
        }
    }
}
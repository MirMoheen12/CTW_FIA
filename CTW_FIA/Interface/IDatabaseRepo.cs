using System.Data;
using Microsoft.Data.SqlClient;

namespace CTW_FIA.Interface
{
    public interface IDatabaseRepo
    {
        public List<SqlParameter> returnSppram(Object obj);
        public List<Object> ConverttoObject(DataTable data, Type objectType);
        public DataTable ExecuteProc(string pProcedureName, List<SqlParameter> param);


    }
}

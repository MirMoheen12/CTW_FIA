using CTW_FIA.Interface;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace CTW_FIA.Repositories
{
    public class DatabaseRepo:IDatabaseRepo
    {
        private readonly IConfiguration _configuration;
   
        public DatabaseRepo(IConfiguration configuration)
        {
            this._configuration = configuration;
           
        }
        public List<SqlParameter> returnSppram(Object obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            Type objectType = obj.GetType();
            PropertyInfo[] properties = objectType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@" +property.Name, property.GetValue(obj)));
            }
            return parameters;
        }
        public List<Object> ConverttoObject(DataTable data, Type objectType)
        {
            List<Object> objectList = new List<Object>();
            foreach (DataRow row in data.Rows)
                {
                    object obj = Activator.CreateInstance(objectType);
                     foreach (DataColumn column in data.Columns)
                    {
                        string propertyName = column.ColumnName;
                        object? propertyValue = row[column];
                        PropertyInfo property = objectType.GetProperty(propertyName);
                        if (property != null && property.CanWrite)
                        {
                        property.SetValue(obj, propertyValue.ToString());
                        }
            }
            objectList.Add(obj);
        }
        return objectList;
    }
        public DataTable ExecuteProc(string conn, string pProcedureName,List<SqlParameter> param)
        {
            DataTable data = new DataTable();
            using (SqlConnection mobjConnection = new SqlConnection(conn))
            {
                using (SqlCommand mobjCommand = new SqlCommand(pProcedureName,
               mobjConnection))
                {
                    mobjCommand.CommandType = CommandType.StoredProcedure;
                    //mobjCommand.CommandTimeout = CommandTimeOut;// 20;
                    if (param != null)
                    {
                        for (int i = 0; i < param.Count; i++)
                        {
                            if (param[i] != null)
                            {
                                mobjCommand.Parameters.Add(param[i]);
                            }
                        }
                    }
                    try
                    {
                        mobjConnection.Open();
                        SqlDataAdapter mobjAdapter;
                        mobjAdapter = new SqlDataAdapter(mobjCommand);
                        DataSet mDataSet = new DataSet();
                        mobjAdapter.Fill(mDataSet);
                        data = mDataSet.Tables[0];
                    }
                    catch (System.Data.SqlClient.SqlException Ex)
                    {

                    }
                    catch (Exception ex)
                    {

                     }
                    finally
                    {
                        mobjCommand.Dispose();
                        mobjConnection.Close();
                        mobjConnection.Dispose();
                    }
                    return data;
                }
            }
        }
    }
}

using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System.Data;


namespace CTW_FIA.Interface
{
    public interface IStoredProcedure
    {
        public DataTable ExecuteStoredProcedure(string storedProcedure);
        public DataTable GetUserByCredentials(string username, string password);


    }
}

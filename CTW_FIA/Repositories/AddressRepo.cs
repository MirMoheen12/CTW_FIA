using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;

namespace CTW_FIA.Repositories
{
    public class AddressRepo : IAddress
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly AppDbContext dbContext;
        public AddressRepo(IDatabaseRepo databaseRepo,  AppDbContext dbContext)
        {
            this.databaseRepo = databaseRepo;
            this.dbContext = dbContext;
        }
        public string AddAddress(Address address)
        {
            try
            {

                address.strURN = databaseRepo.ExecuteProc("GetAddressSTRURN", null).Rows[0][0].ToString();
                address.CreatedOn = DateTime.Now;
                address.textSearch = address.strURN+" "+ address.Country.ToString() + " " + address.Province.ToString() + " " + address.District.ToString();
                dbContext.Address.Add(address);
                dbContext.SaveChanges();
               return address.strURN;
            }
            catch (Exception e)
            {
                AddErrorLog(e.Message.ToString());
                return null;

            }
         
        }
        private void AddErrorLog(string Msg)
        {
            var dat = new
            {
                Msg = Msg
            };
            var dbres = databaseRepo.ExecuteProc("InsertErrorLog", databaseRepo.returnSppram(Msg));
        }
    }
}

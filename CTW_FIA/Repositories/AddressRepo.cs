using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

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
        public QuickSearchAddress_sel getAdrsByStrurn(string sTRUN)
        {

            var dat = new
            {
                textSearch = sTRUN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchAddress_sel_web", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchAddress_sel));
            var list = new List<QuickSearchAddress_sel>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchAddress_sel)item);
            }
            return list.FirstOrDefault();
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

using CTW_FIA.Interface;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Repositories
{
    public class CommunicationRepo:ICommunication
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly IConfiguration configuration;
        public CommunicationRepo(IDatabaseRepo databaseRepo, IConfiguration configuration)
        {
            this.configuration=configuration;
            this.databaseRepo = databaseRepo;

        }
        public List<Communications_sel> AllCommunication()
        {
            
            var dat = databaseRepo.ExecuteProc("Communications_sel", null);
            var res = databaseRepo.ConverttoObject(dat, typeof(Communications_sel));
            var list = new List<Communications_sel>();
            foreach (var item in res)
            {
                list.Add((Communications_sel)item);
            }
            return list;

        }
    }
}

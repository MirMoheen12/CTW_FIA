using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace CTW_FIA.Repositories
{
    public class UserReopsitorie:IUser
    {
        private readonly IDatabaseRepo databaseRepo;
		private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public UserReopsitorie(IDatabaseRepo databaseRepo, AppDbContext context,IConfiguration configuration)
        {
            this.configuration=configuration;
            this.databaseRepo = databaseRepo;
            this.context = context;
        }


		public UserDto Login(string userName, string Password)
        {
            try
            {
                var Allsp = new
                {
                    UserName = userName,
                    Password = Password
                };
                var allpram=databaseRepo.returnSppram(Allsp);
                var res = databaseRepo.ExecuteProc("GetUserByCredentials",allpram);
                if(res!=null)
                {
                    UserDto user = new UserDto();
                    var data=databaseRepo.ConverttoObject(res,typeof(UserDto));
                    user = (UserDto)data.FirstOrDefault();
                    return user;
                }
                
                
                return null;
            }
            catch (Exception)
            {

                throw;
            }

        }



        public string GetLocalIPAddress()
        {
            String ipAddress = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
            return ipAddress;
        }

        public string GetLocalMacAddress()
        {

            String macAddress = "";
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.OperationalStatus == OperationalStatus.Up)
                {
                    PhysicalAddress physicalAddress = nic.GetPhysicalAddress();
                    byte[] bytes = physicalAddress.GetAddressBytes();
                    macAddress = string.Join("-", bytes.Select(b => b.ToString("X2")));
                    break;
                }
            }
            return macAddress;
        }
    }
}

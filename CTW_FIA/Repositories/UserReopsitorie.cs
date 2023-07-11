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
        private readonly IStoredProcedure storedProcedure;
		private readonly AppDbContext context;

        public UserReopsitorie(IStoredProcedure storedProcedure, AppDbContext context)
        {

            this.storedProcedure = storedProcedure;
            this.context = context;
        }


		public UserDto Login(string userName, string Password)
        {

            try
            {
                DataTable dataTable = storedProcedure.GetUserByCredentials(userName, Password);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    UserDto user = new UserDto
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        DepartmentID = Convert.ToInt32(row["DepartmentID"]),
                        OfficeID = Convert.ToInt32(row["OfficeID"]),
                        Designation = row["Designation"].ToString(),
                        ActiveUser = Convert.ToBoolean(row["ActiveUser"]),
                        AccountLock = Convert.ToBoolean(row["AccountLock"]),
                        UserRole = row["UserRole"].ToString(),
                    };

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

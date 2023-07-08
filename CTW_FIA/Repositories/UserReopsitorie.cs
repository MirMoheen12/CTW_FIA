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
		private readonly IConfiguration configuration;

		private readonly AppDbContext context;
        public UserReopsitorie(IConfiguration configuration,AppDbContext context)
        {

            this.configuration = configuration;
            this.context = context;
        }


		private UserDto GetUserByCredentials(string userName, string password)
		{
            try
            {
				string connectionString = configuration.GetConnectionString("DefaultConnection");

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					using (SqlCommand command = new SqlCommand("GetUserByCredentials", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@UserName", userName);
						command.Parameters.AddWithValue("@Password", password);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
							{
								reader.Read();

								UserDto user = new UserDto
								{
									UserID = Convert.ToInt32(reader["UserID"]),
									UserName = reader["UserName"].ToString(),
									Password = reader["Password"].ToString(),
									DepartmentID = Convert.ToInt32(reader["DepartmentID"]),
									OfficeID = Convert.ToInt32(reader["OfficeID"]),
									Designation = reader["Designation"].ToString(),
									ActiveUser = Convert.ToBoolean(reader["ActiveUser"]),
									AccountLock = Convert.ToBoolean(reader["AccountLock"]),
									UserRole = reader["UserRole"].ToString(),
								};
								return user;

							}
						}
					}

				}

				return null;
			}
            catch (Exception)
            {

                throw;
            }
			
		}


		public bool Login(string userName, string Password)
        {
            UserDto User = GetUserByCredentials(userName, Password);

            if (User == null)
                return false;
            else return true;
            //try
            //{
            //    if (UserData != null)
            //	{
            //		//UserData.LastLoginTimestamp = DateTime.UtcNow;
            //		String localIpAddress = GetLocalIPAddress();
            //		String localMacAddress = GetLocalIPAddress();
            //		var macmatch = context.MacAddress.Where(x => x.MAC_Address == localMacAddress).FirstOrDefault();
            //		if (macmatch != null)
            //		{
            //			var ipmatch = context.IpLogs.Where(x => x.IsDeleted == false && x.IP == localIpAddress).FirstOrDefault();
            //			if (ipmatch != null)
            //			{
            //                         //signinTrue
            //				return true;
            //			}
            //		}
            //	}
            //	return false;
            //}
            //catch (Exception)
            //{

            //	throw;
            //}
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

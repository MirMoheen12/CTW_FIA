using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace CTW_FIA.Repositories
{
    public class UserReopsitorie:IUser
    {
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public UserReopsitorie(AppDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {

            this.context = context;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._signInManager = signInManager;
        }

        public bool Login(string userName, string Password)
        {
            var data = VerifyLogin(userName, Password).GetAwaiter().GetResult();
            return data;
        }


        private async Task<bool>  VerifyLogin(string userName, string Password)
        {
            try
            {
                var UserData = await _userManager.FindByNameAsync(userName);
                if (UserData != null && await _userManager.CheckPasswordAsync(UserData, Password))
                {
                    //UserData.LastLoginTimestamp = DateTime.UtcNow;
                    String localIpAddress = GetLocalIPAddress();
                    String localMacAddress = GetLocalIPAddress();
                    var macmatch = context.MacAddress.Where(x => x.MAC_Address == localMacAddress).FirstOrDefault();
                    if(macmatch != null)
                    {
                        var ipmatch = context.IpLogs.Where(x => x.IsDeleted == false && x.IP == localIpAddress).FirstOrDefault();
                        if(ipmatch != null)
                        {

                            await _signInManager.SignInAsync(UserData, isPersistent: false);
                            return true;
                        }
                    }
                }
                return false;
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

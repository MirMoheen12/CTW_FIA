namespace CTW_FIA.Models.DatabaseModels
{
    public class UserAccessRights
    {
        public int Rid { get; set; }
        public string TableName { get; set; }
        public bool ReadAccess { get; set; }
        public bool WriteAccess { get; set; }
        public bool ReadWrite { get; set; }
        public string Userid { get; set; }
    }

}

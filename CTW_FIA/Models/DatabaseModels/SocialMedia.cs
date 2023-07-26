using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class SocialMedia
    {
        [Key]
        public int ProfileID { get; set; }
        public string SocialMediaProfile { get; set; }
        public string PersonstrURN { get; set; }
    }

}

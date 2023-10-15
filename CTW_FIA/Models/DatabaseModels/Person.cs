using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Person
    {
        [Key]
        public string strURN { get; set; }

        //[Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
       // [Required]
        public string CurrentStatus { get; set; }
       // [Required]
        public string ReportingAgency { get; set; }
        public Nullable<int> NHeadMoney { get; set; }
        //[Required]
        public string AccusationStatus { get; set; }
       // [Required]
        public string Name { get; set; }
        public string Aliases { get; set; }
        public string FatherName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Tribe { get; set; }
        public Nullable<long> CNIC { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string Education { get; set; }
        public string Email { get; set; }
        public string NormalDress { get; set; }
        public string BodyStructure { get; set; }
        public string BodyBuild { get; set; }
        public string BeardColor { get; set; }
        public string BaldType { get; set; }
        public string Height { get; set; }
        public string HeightInFeet { get; set; }
        public string Complexion { get; set; }
        public string IdentificationMark { get; set; }
        public string PermanentIdentificationMark { get; set; }
        public string DistinguishingMarks { get; set; }
        public string CovertAppearance { get; set; }
        public string OvertAppearance { get; set; }
        public string TalkingStyle { get; set; }
        public string VoicePitch { get; set; }
        public string HairCutStyle { get; set; }
        public string HairType { get; set; }
        public string HairColor { get; set; }
        public bool HairImplants { get; set; }
        public bool Wig { get; set; }
        public string CheekStructure { get; set; }
        public Nullable<bool> ContactLenses { get; set; }
        public string VFaceShape { get; set; }
        public string EarStructure { get; set; }
        public string EyeColor { get; set; }
        public string EyeLook { get; set; }
        public string Eyebrows { get; set; }
        public Nullable<bool> EyeGlasses { get; set; }
        public string NoseStructure { get; set; }
        public string LipStucture { get; set; }
        public string Mustaches { get; set; }
        public string MustachesColor { get; set; }
        public string memRemarks { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public bool iSHeadMoney { get; set; }
        public bool isActive { get; set; }
        public string FirNo { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sect { get; set; }
        public string Affiliation { get; set; }
        public string Languages { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
        [NotMapped]
        public int intID { get; set; }
        [NotMapped]
        public string? Country { get; set; }
        [NotMapped]
        public string? PoliceAstation { get; set; }
        [NotMapped]
        public string? Province { get; set; }
        [NotMapped]
        public string? District { get; set; }
        [NotMapped]
        public string? AddressDescription { get; set; }
        [NotMapped]
        public string? Postelcode { get; set; }
        [NotMapped]
        public string? SocialMediaAccounts { get; set; }
        [NotMapped]
        public string? PassPortNo { get; set; }

    }

}

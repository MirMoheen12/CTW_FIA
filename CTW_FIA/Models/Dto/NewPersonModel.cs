using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class NewPersonModel
    {
        [Display(Name = "Str URN")]
        public string? StrURN { get; set; }

        [Display(Name = "Adrs Str URN")]
        public string? AdrsStrURN { get; set; }

        [Display(Name = "Category")]
        public string? Category { get; set; }

        [Display(Name = "Current Status")]
        public string? CurrentStatus { get; set; }

        [Display(Name = "Reporting Agency")]
        public string? ReportingAgency { get; set; }

        [Display(Name = "Fir No")]
        public string? FirNo { get; set; }

        [Display(Name = "N Head Money")]
        public string? NHeadMoney { get; set; }

        [Display(Name = "Is Head Money")]
        public string? iSHeadMoney { get; set; }

        [Display(Name = "Is Active")]
        public string? isActive { get; set; }

        [Display(Name = "Accusation Status")]
        public string? AccusationStatus { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Aliases")]
        public string? Aliases { get; set; }

        [Display(Name = "Father Name")]
        public string? FatherName { get; set; }

        [Display(Name = "Family Name")]
        public string? FamilyName { get; set; }

        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Display(Name = "DOB")]
        public string? DOB { get; set; }

        [Display(Name = "Age")]
        public string? Age { get; set; }

        [Display(Name = "Place of Birth")]
        public string? PlaceOfBirth { get; set; }

        [Display(Name = "Tribe")]
        public string? Tribe { get; set; }

        [Display(Name = "CNIC")]
        public string? CNIC { get; set; }

        [Display(Name = "Marital Status")]
        public string? MaritalStatus { get; set; }

        [Display(Name = "Religion")]
        public string? Religion { get; set; }

        [Display(Name = "Occupation")]
        public string? Occupation { get; set; }

        [Display(Name = "Education")]
        public string? Education { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Normal Dress")]
        public string? NormalDress { get; set; }

        [Display(Name = "Body Structure")]
        public string? BodyStructure { get; set; }

        [Display(Name = "Body Build")]
        public string? BodyBuild { get; set; }

        [Display(Name = "Beard Color")]
        public string? BeardColor { get; set; }

        [Display(Name = "Bald Type")]
        public string? BaldType { get; set; }

        [Display(Name = "Height")]
        public string? Height { get; set; }

        [Display(Name = "Height In Feet")]
        public string? HeightInFeet { get; set; }

        [Display(Name = "Complexion")]
        public string? Complexion { get; set; }

        [Display(Name = "Identification Mark")]
        public string? IdentificationMark { get; set; }

        [Display(Name = "Permanent Identification Mark")]
        public string? PermanentIdentificationMark { get; set; }

        [Display(Name = "Distinguishing Marks")]
        public string? DistinguishingMarks { get; set; }

        [Display(Name = "Covert Appearance")]
        public string? CovertAppearance { get; set; }

        [Display(Name = "Overt Appearance")]
        public string? OvertAppearance { get; set; }

        [Display(Name = "Talking Style")]
        public string? TalkingStyle { get; set; }

        [Display(Name = "Voice Pitch")]
        public string? VoicePitch { get; set; }

        [Display(Name = "Hair Cut Style")]
        public string? HairCutStyle { get; set; }

        [Display(Name = "Hair Type")]
        public string? HairType { get; set; }

        [Display(Name = "Hair Color")]
        public string? HairColor { get; set; }

        [Display(Name = "Hair Implants")]
        public string? HairImplants { get; set; }

        [Display(Name = "Wig")]
        public string? Wig { get; set; }

        [Display(Name = "Cheek Structure")]
        public string? CheekStructure { get; set; }

        [Display(Name = "Contact Lenses")]
        public string? ContactLenses { get; set; }

        [Display(Name = "V Face Shape")]
        public string? VFaceShape { get; set; }

        [Display(Name = "Ear Structure")]
        public string? EarStructure { get; set; }

        [Display(Name = "Eye Color")]
        public string? EyeColor { get; set; }

        [Display(Name = "Eye Look")]
        public string? EyeLook { get; set; }

        [Display(Name = "Eyebrows")]
        public string? Eyebrows { get; set; }

        [Display(Name = "Eye Glasses")]
        public string? EyeGlasses { get; set; }

        [Display(Name = "Nose Structure")]
        public string? NoseStructure { get; set; }

        [Display(Name = "Lip Structure")]
        public string? LipStucture { get; set; }

        [Display(Name = "Mustaches")]
        public string? Mustaches { get; set; }

        [Display(Name = "Mustaches Color")]
        public string? MustachesColor { get; set; }

        [Display(Name = "Mem Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Passport No")]
        public string? PassportNo { get; set; }

        [Display(Name = "Social Media Profile")]
        public string? SocialMediaProfile { get; set; }

        [Display(Name = "Country")]
        public string? Country { get; set; }

        [Display(Name = "Province Or State")]
        public string? ProvinceOrState { get; set; }

        [Display(Name = "District")]
        public string? District { get; set; }

        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name = "Address Description")]
        public string? AddressDescription { get; set; }

        [Display(Name = "Address Name")]
        public string? AddressName { get; set; }

        [Display(Name = "Address Type")]
        public string? AddressType { get; set; }

        [Display(Name = "House Number")]
        public string? HouseNumber { get; set; }

        [Display(Name = "Province")]
        public string? Province { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Street Number")]
        public string? StreetNumber { get; set; }

        [Display(Name = "Mohallah")]
        public string? Mohallah { get; set; }

        [Display(Name = "Village")]
        public string? Village { get; set; }

        [Display(Name = "Town")]
        public string? Town { get; set; }

        [Display(Name = "Post Office")]
        public string? PostOffice { get; set; }

        [Display(Name = "Tehsil/Taluka")]
        public string? TehsilTaluka { get; set; }

        [Display(Name = "Postal/Zip")]
        public string? PostalZip { get; set; }

        [Display(Name = "Commonwealth Territory")]
        public string? CommonwealthTerritory { get; set; }

        [Display(Name = "Latitude")]
        public string? Latitude { get; set; }

        [Display(Name = "Longitude")]
        public string? Longitude { get; set; }

        [Display(Name = "Other 1")]
        public string? Other1 { get; set; }

        [Display(Name = "Other 2")]
        public string? Other2 { get; set; }

        [Display(Name = "Date Sent")]
        public string? dteSent { get; set; }

        [Display(Name = "Walking Style")]
        public string? WalkingStyle { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTW_FIA.Models.Dto
{
    public class NewPersonModel
    {
        public string StrURN { get; set; }
        public string AdrsStrURN { get; set; }
        public string Category { get; set; }
  
        public string CurrentStatus { get; set; }
        public string ReportingAgency { get; set; }
        public string FirNo { get; set; }

        public int? NHeadMoney { get; set; }
        public bool iSHeadMoney { get; set; } = false;

        public bool isActive { get; set; } = false;
        public string AccusationStatus { get; set; }

        
        public string Name { get; set; }

      
        public string Aliases { get; set; }


        public string FatherName { get; set; }

      
        public string FamilyName { get; set; }     
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public int? Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Tribe { get; set; }
        public int? CNIC { get; set; }

        
        public string MaritalStatus { get; set; }

        
        public string Religion { get; set; }

        
        public string Occupation { get; set; }

        
        public string Education { get; set; }


        //Contact Details


        public string Email { get; set; }

        //Physical Appearence

        //Dress
        
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

        //Hair Appearence 


        public string HairCutStyle { get; set; }


        public string HairType { get; set; }

        
        public string HairColor { get; set; }

      
        public bool? HairImplants { get; set; }

      
        public bool? Wig { get; set; }


        //Face Appearence 


        public string CheekStructure { get; set; }

      
        public bool? ContactLenses { get; set; }



        public string VFaceShape { get; set; }


        public string EarStructure { get; set; }

        
        public string EyeColor { get; set; }


        public string EyeLook { get; set; }


        public string Eyebrows { get; set; }

      
        public bool? EyeGlasses { get; set; }



        public string NoseStructure { get; set; }



        public string LipStucture { get; set; }


        public string Mustaches { get; set; }

        
        public string MustachesColor { get; set; }

      
        public string memRemarks { get; set; }
        public string PassportNo { get; set; }
        public string SocialMediaProfile { get; set; }
        
        public string Country { get; set; }

        
        public string ProvinceOrState { get; set; }

        
        public string District { get; set; }

      
        public string PostalCode { get; set; }

       
        public string Address { get; set; }

        
        public string AddressDescription { get; set; }


        
        public string AddressName { get; set; }


        
        public string AddressType { get; set; }


        public int? HouseNumber { get; set; }


        
      


        
        public string Province { get; set; }


       
       


       
        public string City { get; set; }


        public int? StreetNumber { get; set; }



        public string Mohallah { get; set; }



        public string Village { get; set; }



        public string Town { get; set; }

       
        public string PostOffice { get; set; }



        public string TehsilTaluka { get; set; }


      
        public string PostalZip { get; set; }


        
        public string CommonwealthTerritory { get; set; }


        public float? Latitude { get; set; }

        public float? Longitude { get; set; }


        
        public string Other1 { get; set; }


        
        public string Other2 { get; set; }

      
        public DateTime? dteSent { get; set; }
        public string WalkingStyle { get; set; }



    }
}

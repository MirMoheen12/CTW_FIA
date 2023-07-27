using CTW_FIA.Interface;
using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;
using System;
using System.Data;

namespace CTW_FIA.Repositories
{
    public class Terroristrepo : ITerrorist
    {
        private readonly IDatabaseRepo databaseRepo;
        private readonly ICommonlinks commonlinks;
        private readonly AppDbContext dbContext;
        private readonly IAddress _address;
        private readonly IMediaFiles _mediaFiles;
        public Terroristrepo(IDatabaseRepo databaseRepo, ICommonlinks commonlinks, AppDbContext dbContext, IAddress _address,IMediaFiles _media)
        {
            this.databaseRepo = databaseRepo;
            this.commonlinks = commonlinks;
            this.dbContext = dbContext;
            this._address = _address;
            this._mediaFiles = _media;
        }

        public bool AddNewPerson(Person P,IFormFile? formFile)
        {
         
            try
            {
               string pstrurn= AddNewTerrorist(P);
                Address address = new Address();
                address.Country = P.Country;
                address.AddressDescription = P.AddressDescription;
                address.Province = P.Province;
                address.District = P.District;
                address.PostalZip = P.Postelcode;
                string adrsUrn = _address.AddAddress(address);
                var cl = commonlinks.CreateCommonlinks(pstrurn, adrsUrn, "Person", "Address", "Intial Insert", address.Country.ToString() + ' ' + address.AddressDescription.ToString());
                    if(formFile!=null)
                {
                 
                    MediaFile media = new MediaFile();
                    media.FileName= formFile.FileName;  
                    media.ContentType = formFile.ContentType;
                    media.Description = "Person Image";
                    media.FilePath = _mediaFiles.AddFileIntoServer(formFile);
                    string medstrurn = _mediaFiles.AddMedia(media);
                    commonlinks.CreateCommonlinks(pstrurn, medstrurn, "Person", "MediaFile", "Media File", address.Country.ToString() + ' ' + address.AddressDescription.ToString());

                }
                if(P.SocialMediaAccounts!=null)
                {
                    SocialMedia socialMedia = new SocialMedia();
                    socialMedia.SocialMediaProfile = P.SocialMediaAccounts;
                    socialMedia.PersonstrURN = P.strURN;
                    dbContext.SocialMedia.Add(socialMedia);
                    dbContext.SaveChanges();
                }
                if(P.CNIC!=null)
                {
                    tblCNIC tblCNIC = new tblCNIC();
                    tblCNIC.strURN= databaseRepo.ExecuteProc("GetCNICSTRURN", null).Rows[0][0].ToString();
                    tblCNIC.strCNIC = P.CNIC.ToString();
                    tblCNIC.dteSent = DateTime.Now;
                    tblCNIC.excl_memTextSearch = P.CNIC.ToString();
                    dbContext.tblCNIC.Add(tblCNIC);
                    dbContext.SaveChanges();
                    commonlinks.CreateCommonlinks(pstrurn, tblCNIC.strURN, "Person", "tblCNIC", "CNIC", address.Country.ToString() + ' ' + address.AddressDescription.ToString());
                }
                if(P.PassPortNo!=null)
                {
                    tblPassport tblPassport = new tblPassport();
                    tblPassport.strURN= databaseRepo.ExecuteProc("tblPassportSTRURN", null).Rows[0][0].ToString();
                    tblPassport.strPassportNo = P.PassPortNo;
                    tblPassport.strCountry = "";
                    tblPassport.dteIssue = null;
                    tblPassport.strPlaceIssue = null;
                    tblPassport.dteExpire = null;
                    tblPassport.strLegacyCode = null;
                    tblPassport.strPrimaryMediaImageUrn = null;
                    tblPassport.optLibrary = null;
                    tblPassport.optTransmit = null;
                    tblPassport.memRemarks = null;
                    tblPassport.optCompliance = false;
                    tblPassport.strSecurityRating = null;
                    tblPassport.dteSent = null;
                    tblPassport.strCreatedBy = "";
                    tblPassport.dteCreated = DateTime.Now;
                    dbContext.tblPassport.Add(tblPassport);
                    dbContext.SaveChanges();
                    commonlinks.CreateCommonlinks(pstrurn, tblPassport.strURN, "Person", "tblPassport", "tblPassport", address.Country.ToString() + ' ' + address.AddressDescription.ToString());

                }
                return true;
            }
            catch (Exception e)
            {
                AddErrorLog(e.Message.ToString());
                return false;

            }
        }

        public List<ReportingAgency> AllAgencies()
        {
            var data = dbContext.ReportingAgency.ToList();
            return (data);
        }

        public List<CountryList> AllCountry()
        {
            var dbres = databaseRepo.ExecuteProc("getAllCountries",null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(CountryList));
            var list = new List<CountryList>();
            foreach (var item in dt)
            {
                list.Add((CountryList)item);
            }
            return (list);
        }

        public List<DistrictList> GetAllDistrictByProvince(string Province)
        {
            var dat = new
            {
                Province = Province
            };
            var dbres = databaseRepo.ExecuteProc("DistrictList_Web", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(DistrictList));
            var list = new List<DistrictList>();
            foreach (var item in dt)
            {
                list.Add((DistrictList)item);
            }
            return (list);
        }

        public List<ProvinceList> GetALlprovinceCountryWise(string Country)
        {
            var dbres = databaseRepo.ExecuteProc("ProvinceList_sel", null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(ProvinceList));
            var list = new List<ProvinceList>();
            foreach (var item in dt)
            {
                list.Add((ProvinceList)item);
            }
            return (list);
        }

        public List<TerroristGroup_Records> GetAllTerrorist()
        {
            
            var dbres = databaseRepo.ExecuteProc( "Groups_sel2", null);
            var dt = databaseRepo.ConverttoObject(dbres, typeof(TerroristGroup_Records));
            var list = new List<TerroristGroup_Records>();
            foreach (var item in dt)
            {
                list.Add((TerroristGroup_Records)item);
            }
            return (list);

        }

        public QuickSearchPerson_sel_Result GetPeronByID(string STRURN)
        {
            var dat = new
            {
                textSearch = STRURN
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchPerson_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchPerson_sel_Result));
            var list = new List<QuickSearchPerson_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchPerson_sel_Result)item);
            }
            return list.FirstOrDefault();
        }

        public List<NewPerson_Provinces_Result> GetPeronProvincewise(string Province)
        {
           
            var dat = new
            {
                provinceName = Province
            };
            var dbres = databaseRepo.ExecuteProc("NewPerson_Provinces", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(NewPerson_Provinces_Result));
            var list = new List<NewPerson_Provinces_Result>();
            foreach (var item in dt)
            {
                list.Add((NewPerson_Provinces_Result)item);
            }
            return (list);
           
        }

        private string AddNewTerrorist(Person P)
        {
           
                P.strURN = databaseRepo.ExecuteProc("GetPersonSTRURN", null).Rows[0][0].ToString();
                var res = dbContext.Person.Add(P);
                P.CreatedOn = DateTime.Now;
                P.textSearch = P.Name + " " + P.strURN + " " + P.memRemarks + " " + P.CNIC.ToString();
                dbContext.SaveChanges();
                return P.strURN;
     
            
        }
        private void AddErrorLog(string Msg)
        {
            var dat = new
            {
                Msg = Msg
            };
            var dbres = databaseRepo.ExecuteProc("InsertErrorLog", databaseRepo.returnSppram(Msg));
        }

        public QuickSearchGroups_sel_Result GetGroupsByStrurn(string Strurn)
        {
            var dat = new
            {
                textSearch = Strurn
            };
            var dbres = databaseRepo.ExecuteProc("QuickSearchExplosives_sel", databaseRepo.returnSppram(dat));
            var dt = databaseRepo.ConverttoObject(dbres, typeof(QuickSearchGroups_sel_Result));
            var list = new List<QuickSearchGroups_sel_Result>();
            foreach (var item in dt)
            {
                list.Add((QuickSearchGroups_sel_Result)item);
            }
            return list.FirstOrDefault();

        }
    }
}

using CTW_FIA.Interface;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CTW_FIA.Models.DatabaseModels
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {

        }


        public DbSet<MacAddress> MacAddress { get; set; }
        public DbSet<BaseLogs> BaseLogs { get; set; }
        public DbSet<IpLogs> IpLogs { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Communications> Communications { get; set; }
        public DbSet<Evidence> Evidence { get; set; }
        public DbSet<Explosive> Explosive { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Firearms> Firearms { get; set; }
        public DbSet<Incident> Incident { get; set; }
        public DbSet<PersonAddress> PersonAddress { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<MediaFile> MediaFile { get; set; }
        public DbSet<Chemical> Chemical { get; set; }
        public DbSet<Components> Components { get; set; }
        public DbSet<InitiationSystem> InitiationSystem { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<PowerSource> PowerSource { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<ContactNumber> ContactNumber { get; set; }
        public DbSet<CBRN> CBRN { get; set; }
        public DbSet<Ordinance> Ordinance { get; set; }
        public DbSet<Pipe> Pipe { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<CommonLinks> CommonLinks { get; set; }
        public DbSet<ReportingAgency> ReportingAgency { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Detonator> Detonator { get; set; }
        public DbSet<Ordnance> Ordnance { get; set; }
        public DbSet<ProvinceList> ProvinceList { get; set; }
        public DbSet<DistrictList> DistrictList { get; set; }
        public DbSet<CountryList> CountryList { get; set; }
        public DbSet<CityList> CityList { get; set; }
        public DbSet<PoliceStation> PoliceStation { get; set; }
        public DbSet<DatabaseList> DatabaseList { get; set; }
        public DbSet<DistrictDatas> DistrictDatas { get; set; }
        public DbSet<DistrictPS> DistrictPS { get; set; }
        public DbSet<AllTable> AllTables { get; set; }
        public DbSet<UserAccessRights> UserAccessRights { get; set; }


        //public DbSet<Paymencategory> Paymencategory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            // Other configurations...
            modelBuilder.Entity<MacAddress>().HasNoKey();
            modelBuilder.Entity<BaseLogs>().HasNoKey();
            modelBuilder.Entity<IpLogs>().HasNoKey();
            modelBuilder.Entity<Address>().HasNoKey();
            modelBuilder.Entity<Communications>().HasNoKey();
            modelBuilder.Entity<Evidence>().HasNoKey();
            modelBuilder.Entity<Explosive>().HasNoKey();
            modelBuilder.Entity<Equipment>().HasNoKey();
            modelBuilder.Entity<Firearms>().HasNoKey();
            modelBuilder.Entity<Incident>().HasNoKey();
            modelBuilder.Entity<PersonAddress>().HasNoKey();
            modelBuilder.Entity<SocialMedia>().HasNoKey();
            modelBuilder.Entity<MediaFile>().HasNoKey();
            modelBuilder.Entity<Chemical>().HasNoKey();
            modelBuilder.Entity<Components>().HasNoKey();
            modelBuilder.Entity<InitiationSystem>().HasNoKey();
            modelBuilder.Entity<Vehicle>().HasNoKey();
            modelBuilder.Entity<PowerSource>().HasNoKey();
            modelBuilder.Entity<Person>().HasNoKey();
            modelBuilder.Entity<BankAccount>().HasNoKey();
            modelBuilder.Entity<ContactNumber>().HasNoKey();
            modelBuilder.Entity<CBRN>().HasNoKey();
            modelBuilder.Entity<Ordinance>().HasNoKey();
            modelBuilder.Entity<Pipe>().HasNoKey();
            modelBuilder.Entity<Property>().HasNoKey();
            modelBuilder.Entity<CommonLinks>().HasNoKey();
            modelBuilder.Entity<ReportingAgency>().HasNoKey();
            modelBuilder.Entity<Group>().HasNoKey();
            modelBuilder.Entity<Detonator>().HasNoKey();
            modelBuilder.Entity<Ordnance>().HasNoKey();
            modelBuilder.Entity<ProvinceList>().HasNoKey();
            modelBuilder.Entity<DistrictList>().HasNoKey();
            modelBuilder.Entity<CountryList>().HasNoKey();
            modelBuilder.Entity<CityList>().HasNoKey();
            modelBuilder.Entity<PoliceStation>().HasNoKey();
            modelBuilder.Entity<DatabaseList>().HasNoKey();
            modelBuilder.Entity<DistrictDatas>().HasNoKey();
            modelBuilder.Entity<DistrictPS>().HasNoKey();
            modelBuilder.Entity<AllTable>().HasNoKey();
            modelBuilder.Entity<UserAccessRights>().HasNoKey();
            base.OnModelCreating(modelBuilder);
		}
	}
}

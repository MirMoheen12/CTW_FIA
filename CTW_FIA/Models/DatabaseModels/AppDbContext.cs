using CTW_FIA.Interface;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CTW_FIA.Models.DatabaseModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    

        public DbSet<ReportingAgency> ReportingAgency { get; set; }


        //public DbSet<Paymencategory> Paymencategory { get; set; }
        //      protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //          // Other configurations...
        //          modelBuilder.Entity<MacAddress>().HasNoKey();
        //          modelBuilder.Entity<BaseLogs>().HasNoKey();
        //          modelBuilder.Entity<IpLogs>().HasNoKey();
        //          modelBuilder.Entity<Address>().HasNoKey();
        //          modelBuilder.Entity<Communications>().HasNoKey();
        //          modelBuilder.Entity<Evidence>().HasNoKey();
        //          modelBuilder.Entity<Explosive>().HasNoKey();
        //          modelBuilder.Entity<Equipment>().HasNoKey();
        //          modelBuilder.Entity<Firearms>().HasNoKey();
        //          modelBuilder.Entity<Incident>().HasNoKey();
        //          modelBuilder.Entity<PersonAddress>().HasNoKey();
        //          modelBuilder.Entity<SocialMedia>().HasNoKey();
        //          modelBuilder.Entity<MediaFile>().HasNoKey();
        //          modelBuilder.Entity<Chemical>().HasNoKey();
        //          modelBuilder.Entity<Components>().HasNoKey();
        //          modelBuilder.Entity<InitiationSystem>().HasNoKey();
        //          modelBuilder.Entity<Vehicle>().HasNoKey();
        //          modelBuilder.Entity<PowerSource>().HasNoKey();
        //          modelBuilder.Entity<Person>().HasNoKey();
        //          modelBuilder.Entity<BankAccount>().HasNoKey();
        //          modelBuilder.Entity<ContactNumber>().HasNoKey();
        //          modelBuilder.Entity<CBRN>().HasNoKey();
        //          modelBuilder.Entity<Ordinance>().HasNoKey();
        //          modelBuilder.Entity<Pipe>().HasNoKey();
        //          modelBuilder.Entity<Property>().HasNoKey();
        //          modelBuilder.Entity<CommonLinks>().HasNoKey();
        //          modelBuilder.Entity<ReportingAgency>().HasNoKey();
        //          modelBuilder.Entity<Group>().HasNoKey();
        //          modelBuilder.Entity<Detonator>().HasNoKey();
        //          modelBuilder.Entity<Ordnance>().HasNoKey();
        //          modelBuilder.Entity<ProvinceList>().HasNoKey();
        //          modelBuilder.Entity<DistrictList>().HasNoKey();
        //          modelBuilder.Entity<CountryList>().HasNoKey();
        //          modelBuilder.Entity<CityList>().HasNoKey();
        //          modelBuilder.Entity<PoliceStation>().HasNoKey();
        //          modelBuilder.Entity<DatabaseList>().HasNoKey();
        //          modelBuilder.Entity<DistrictDatas>().HasNoKey();
        //          modelBuilder.Entity<DistrictPS>().HasNoKey();
        //          modelBuilder.Entity<AllTable>().HasNoKey();
        //          modelBuilder.Entity<UserAccessRights>().HasNoKey();
        //          base.OnModelCreating(modelBuilder);
        //}
    }
}

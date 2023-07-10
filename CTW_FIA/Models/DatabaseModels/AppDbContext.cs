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
		public DbSet<IpLogs> IpLogs { get; set; }

		//public DbSet<Paymencategory> Paymencategory { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Other configurations...

			base.OnModelCreating(modelBuilder);
		}
	}
}

using ELM.APIs.LicenseService.Models;
using Microsoft.EntityFrameworkCore;
 

namespace ELM.APIs.LicenseService.Data
{
    public class LicenseDBContext : DbContext
    {
        public DbSet<License> Licenses { get; set; }
        public LicenseDBContext(DbContextOptions<LicenseDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder ) 
        {
        modelBuilder.Entity<License>().HasIndex(l=>l.Key).IsUnique();
        }
    }
}

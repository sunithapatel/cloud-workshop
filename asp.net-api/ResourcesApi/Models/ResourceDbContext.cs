using Microsoft.EntityFrameworkCore;

namespace ResourcesApi.Models
{
    public class ResourceDbContext : DbContext
    {
        public ResourceDbContext(DbContextOptions<ResourceDbContext> options) : base(options)
        {
        }

        public DbSet<Resource> Resources { get; set; } = null!;
        public DbSet<ResourceApplicationPeriod> ApplicationPeriods { get; set; } = null!;
        public DbSet<ResourceLocation> Locations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasKey("Id");
            modelBuilder.Entity<Resource>()
                .HasMany<ResourceApplicationPeriod>(r => r.ApplicationPeriods)
                .WithOne(x => x.Resource);
            modelBuilder.Entity<Resource>()
                .HasMany<ResourceLocation>(r => r.Locations)
                .WithOne(l => l.Resource);
        }
    }
}
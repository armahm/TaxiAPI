using Microsoft.EntityFrameworkCore;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().HasMany(p => p.Vehicles).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);

            builder.Entity<Company>().HasData
            (
                new Company { Id = 100, Name = "Red" }, // Id set manually due to in-memory provider
                new Company { Id = 101, Name = "Vojvodjani" }
            );

            builder.Entity<Vehicle>().ToTable("Vehicles");
            builder.Entity<Vehicle>().HasKey(p => p.Id);
            builder.Entity<Vehicle>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Vehicle>().Property(p => p.Type).IsRequired();

            builder.Entity<Vehicle>().HasData
            (
                new Vehicle
                {
                    Id = 100,
                    Type = EType.Spacious,
                    CompanyId = 100
                },
                new Vehicle
                {
                    Id = 101,
                    Type = EType.Regular,
                    CompanyId = 101
                }
            );

            builder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });
        }
    }
}


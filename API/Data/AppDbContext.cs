using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> AppUsers {get;set;}
    public DbSet<CoffeeUser> CoffeeUsers { get; set; }
    public DbSet<Coffee> Coffees { get; set; }
    public DbSet<CoffeePreference> CoffeePreferences { get; set; }
    public DbSet<CoffeeRecommendation> CoffeeRecommendations { get; set; }
    public DbSet<CoffeeFlavorProfile> CoffeeFlavorProfiles { get; set; }
    public DbSet<FlavorProfile> FlavorProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // 1. Configure the One-to-One (AppUser <-> CoffeeUser)
        // This ensures the foreign key (Id) in CoffeeUser is also its primary key.
        modelBuilder.Entity<CoffeeUser>()
            .HasOne(cu => cu.AppUser)
            .WithOne(au => au.CoffeeUser)
            .HasForeignKey<CoffeeUser>(cu => cu.Id);
            // If you changed the property name to AppUserId, use .HasForeignKey<CoffeeUser>(cu => cu.AppUserId);


        // 2. Configure the Many-to-Many Join Table (CoffeeFlavorProfile)
        // Since CoffeeFlavorProfile has two foreign keys as its primary key, 
        // you must explicitly define this composite key.
        modelBuilder.Entity<CoffeeFlavorProfile>()
            .HasKey(cfp => new { cfp.CoffeeId, cfp.FlavorProfileId });

        // Configure the relationships for the composite key table
        modelBuilder.Entity<CoffeeFlavorProfile>()
            .HasOne(cfp => cfp.Coffee)
            .WithMany(c => c.CoffeeFlavorProfiles)
            .HasForeignKey(cfp => cfp.CoffeeId);

        modelBuilder.Entity<CoffeeFlavorProfile>()
            .HasOne(cfp => cfp.FlavorProfile)
            .WithMany(fp => fp.CoffeeFlavorProfiles)
            .HasForeignKey(cfp => cfp.FlavorProfileId);
    }
}

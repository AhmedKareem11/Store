using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Addresses;
using Store.Domain.Entities.Users;


namespace Store.Dal.Context;

public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public DbSet<User> Users { get; set; } = null!;

    public DbSet<City> Cities { get; set; } = null!;

    public DbSet<Governorate> Governorates { get; set; } = null!;


    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
        builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");

        builder.Ignore<IdentityUserClaim<int>>();
        builder.Ignore<IdentityRoleClaim<int>>();
        
    }


}

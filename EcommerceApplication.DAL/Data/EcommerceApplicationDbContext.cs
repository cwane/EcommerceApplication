using EcommerceApplication.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplication.DAL.Data;

public class EcommerceApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public EcommerceApplicationDbContext(DbContextOptions<EcommerceApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    #region DbSet
    public DbSet<User> User {get;set;}
    #endregion
}


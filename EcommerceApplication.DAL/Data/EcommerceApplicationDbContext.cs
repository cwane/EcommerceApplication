using EcommerceApplication.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;

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
        
    }

    #region DbSet
    public DbSet<User> User {get;set;}
    public DbSet<Product> Product { get;set;}
    public DbSet<CartItem> CartItem { get;set;}
   
    #endregion
}


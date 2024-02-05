using F1Lib.Models;
using F1MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1MVC.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationDbUser>
{
    public DbSet<F1Lib.Models.Circuit> Circuits {  get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Grandprix> Grandprix { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Team> Teams { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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
}

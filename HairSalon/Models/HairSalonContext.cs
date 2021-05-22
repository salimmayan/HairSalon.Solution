using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }  //To enable lazy loading, use "virtual" when declaring a context property
    public DbSet<Client> Clients { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //method to enable lazy-loading.
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
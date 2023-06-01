using Microsoft.EntityFrameworkCore;
using EauClairSalon.Models;

#nullable disable
public class EauClairSalonContext : DbContext
{
  public EauClairSalonContext()
  {
  }

  public EauClairSalonContext(DbContextOptions<EauClairSalonContext> options)
    : base(options) 
  {
  }

  public DbSet<Stylist> Stylists { get; set; }
  public DbSet<Client> Clients { get; set; }
}
#nullable enable

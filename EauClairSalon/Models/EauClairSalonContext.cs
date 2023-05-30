using Microsoft.EntityFrameworkCore;

public class EauClairSalonContext : DbContext
{
    public EauClairSalonContext(DbContextOptions<EauClairSalonContext> options)
        : base(options)
    {
    }

    public DbSet<Stylist>? Stylists { get; set; }
    public DbSet<Client>? Clients { get; set; }
}

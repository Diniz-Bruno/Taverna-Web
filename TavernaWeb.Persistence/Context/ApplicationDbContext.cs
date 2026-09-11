using Microsoft.EntityFrameworkCore;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.Context;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        :base(options)
    {
    }
    
    public DbSet<Ordem> FichaOrdem { get; set; }
    public DbSet<Ficha> Fichas { get; set; }
    public DbSet<Pericia> Pericias { get; set; }
    public DbSet<Poderes> Poderes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
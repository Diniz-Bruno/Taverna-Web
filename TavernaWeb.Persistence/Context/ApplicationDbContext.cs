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
    
    //APLICA A LOGICA DPS
}
using TavernaWeb.Domain.Enums.Sistemas;
namespace TavernaWeb.Domain.Models;

public class Ficha
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public SistemasEnum Sistema { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
}
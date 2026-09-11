using TavernaWeb.Domain.Enums.Ordem;

namespace TavernaWeb.Domain.Models;

public class Pericia
{
    public int Id { get; set; }
    public int Idficha { get; set; }        
    public PericiasEnum Nome { get; set; }
    public int ValorBonus { get; set; }
}
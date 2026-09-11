namespace TavernaWeb.Domain.Models;

public class Poderes
{
    public int Id { get; set; }
    public int Idficha { get; set; }        
    public string Nome { get; set; } = string.Empty;
    public int CustoPe { get; set; }
    public string? Descricao { get; set; }
}
using TavernaWeb.Domain.Enums.Ordem;
namespace TavernaWeb.Domain.Models;

public class Ordem
{
    public int Idficha { get; set; }
    public int Nex { get; set; }
    public int Vida { get; set; }
    public int Pe { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ClassesEnum Classe { get; set; }
    public string SubClasse { get; set; } = string.Empty;
    public OrigensEnum Origem { get; set; }
    public List<Poderes> Poderes { get; set; } = new();
    public int Agilidade { get; set; }
    public int Forca { get; set; }
    public int Vigor { get; set; }
    public int Inteligencia { get; set; }
    public int Presenca { get; set; }
    public List<Pericia> Pericias { get; set; } = new();    
}


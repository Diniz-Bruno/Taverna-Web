using TavernaWeb.Domain.Enums.Ordem;

namespace TavernaWeb.Domain.Catalogo;

public class OrigemDetalhes
{
    public OrigensEnum Origem { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public List<PericiasEnum> PericiasTreinadas { get; set; } = new();
    public string? ObservacaoPericias { get; set; }
    public string PoderNome { get; set; } = string.Empty;
    public string PoderDescricao { get; set; } = string.Empty;
    public int CustoPe { get; set; }
    public bool EhPassivo { get; set; }
}

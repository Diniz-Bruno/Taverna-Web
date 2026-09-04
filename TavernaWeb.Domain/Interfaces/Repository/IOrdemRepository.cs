using TavernaWeb.Domain.Enums.Ordem;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Domain.Interfaces.Repository;

public interface IOrdemRepository
{
    // POST - Criar linha da ficha
    Task<int> PostFichaAsync(Ordem ordem);

    // GET - Atributos
    Task<int> GetForcaAsync(int id);
    Task<int> GetPresencaAsync(int id);
    Task<int> GetAgilidadeAsync(int id);
    Task<int> GetVigorAsync(int id);
    Task<int> GetInteligenciaAsync(int id);

    // GET - Perícia (regra de negócio: multiplica o grau 0..3 por 5 => retorna 0, 5, 10 ou 15)
    Task<int> GetPericiaAsync(int id, int numeroPericia);
    Task<int> GetPericiaAsync(int id, PericiasEnum pericia);

    // GET - Grau de treinamento da perícia (retorna o valor bruto de 0 a 3)
    Task<int> GetGrauPericiaAsync(int id, int numeroPericia);
    Task<int> GetGrauPericiaAsync(int id, PericiasEnum pericia);

    // PATCH - Modificar cada parte mutável
    Task<int> PatchNomeAsync(int id, string nome);
    Task<int> PatchNexAsync(int id, int nex);
    Task<int> PatchVidaAsync(int id, int vida);
    Task<int> PatchPeAsync(int id, int pe);
    Task<int> PatchClasseAsync(int id, ClassesEnum classe);
    Task<int> PatchSubClasseAsync(int id, string subClasse);
    Task<int> PatchOrigemAsync(int id, OrigensEnum origem);
    Task<int> PatchAgilidadeAsync(int id, int agilidade);
    Task<int> PatchForcaAsync(int id, int forca);
    Task<int> PatchVigorAsync(int id, int vigor);
    Task<int> PatchInteligenciaAsync(int id, int inteligencia);
    Task<int> PatchPresencaAsync(int id, int presenca);
    Task<int> PatchPoderesAsync(int id, List<string> poderes);

    // PATCH - Perícias (grau limitado de 0 a 3: 0 = +0, 1 = +5, 2 = +10, 3 = +15)
    Task<int> PatchPericiaAsync(int id, int numeroPericia, int grau);
    Task<int> PatchPericiaAsync(int id, PericiasEnum pericia, int grau);
    Task<int> PatchPericiasAsync(int id, Dictionary<PericiasEnum, int> pericias);

    // DELETE - Deletar ficha por ID
    Task<int> DeleteFichaAsync(int id);
}
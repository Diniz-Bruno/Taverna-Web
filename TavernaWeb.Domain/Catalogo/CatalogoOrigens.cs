using TavernaWeb.Domain.Enums.Ordem;

namespace TavernaWeb.Domain.Catalogo;

public static class CatalogoOrigens
{
    private static readonly List<OrigemDetalhes> _origens = new()
    {
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Academico,
            Nome = "Acadêmico",
            Descricao = "Você era um pesquisador ou professor universitário cujos estudos acabaram tocando em assuntos misteriosos e inexplicáveis.",
            PericiasTreinadas = new() { PericiasEnum.Ciencias, PericiasEnum.Investigacao },
            PoderNome = "Saber é Poder",
            PoderDescricao = "Quando faz um teste usando Intelecto (exceto Ocultismo), você pode gastar 2 PE para receber +5 nesse teste.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.AgenteDeSaude,
            Nome = "Agente de Saúde",
            Descricao = "Você era um médico, enfermeiro, paramédico ou socorrista acostumado a lidar com vidas em risco e ferimentos graves.",
            PericiasTreinadas = new() { PericiasEnum.Intuicao, PericiasEnum.Medicina },
            PoderNome = "Técnica Medicinal",
            PoderDescricao = "Sempre que você cura um personagem, você adiciona seu Intelecto no total de PV curados.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Amnesico,
            Nome = "Amnésico",
            Descricao = "Você perdeu a memória antes de ingressar na Ordem. Não se lembra de quem era, mas lampejos do passado ainda ressurgem.",
            PericiasTreinadas = new(),
            ObservacaoPericias = "Duas perícias à escolha do Mestre.",
            PoderNome = "Vislumbres do Passado",
            PoderDescricao = "Uma vez por sessão ou a critério do Mestre, você pode gastar 1 PE para fazer um teste de Intelecto (DT 10) para reconhecer pessoas, lugares ou fatos familiares do seu passado e obter informações úteis.",
            CustoPe = 1,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Artista,
            Nome = "Artista",
            Descricao = "Você era um ator, pintor, escritor ou músico que expressava emoções intensas até ter contato com o Outro Lado.",
            PericiasTreinadas = new() { PericiasEnum.Artes, PericiasEnum.Enganacao },
            PoderNome = "Magnum Opus",
            PoderDescricao = "Você é famoso por uma obra sua. Pode gastar 2 PE para receber +5 em um teste de Presença (exceto para conjurar rituais). Em cenas de interlúdio, sua presença artística ajuda aliados a recuperarem +1 de Sanidade.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Atleta,
            Nome = "Atleta",
            Descricao = "Você dedicou sua vida aos esportes e ao aprimoramento físico antes de aplicar sua disciplina e vigor na luta contra o paranormal.",
            PericiasTreinadas = new() { PericiasEnum.Acrobacia, PericiasEnum.Atletismo },
            PoderNome = "110%",
            PoderDescricao = "Quando faz um teste de perícia que usa Força ou Agilidade (exceto Luta e Pontaria), você pode gastar 2 PE para receber +5 nesse teste.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Chef,
            Nome = "Chef",
            Descricao = "Você dominava os segredos da culinária profissional, nutrindo corpo e mente dos seus companheiros de equipe.",
            PericiasTreinadas = new() { PericiasEnum.Fortitude, PericiasEnum.Profissao },
            PoderNome = "Ingrediente Secreto",
            PoderDescricao = "Em cenas de interlúdio, você pode gastar uma ação para cozinhar um prato especial. Você e todos os membros do grupo que participarem recebem o dobro dos benefícios concedidos pelo prato.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Criminoso,
            Nome = "Criminoso",
            Descricao = "Você vivia fora da lei como ladrão, contrabandista ou falsário até que um trabalho cruzou a fronteira do paranormal.",
            PericiasTreinadas = new() { PericiasEnum.Crime, PericiasEnum.Furtividade },
            PoderNome = "O Crime Compensa",
            PoderDescricao = "No final de uma missão, escolha um item encontrado nela. Em sua próxima missão, você pode incluir esse item em seu inventário sem que ele conte em seu limite de itens por patente.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.CultistaArrependido,
            Nome = "Cultista Arrependido",
            Descricao = "Você fez parte de um culto que servia às entidades do Outro Lado, mas despertou do transe e agora usa o que aprendeu contra eles.",
            PericiasTreinadas = new() { PericiasEnum.Ocultismo, PericiasEnum.Religiao },
            PoderNome = "Traços do Outro Lado",
            PoderDescricao = "Você começa o jogo com um poder paranormal à sua escolha. No entanto, por causa do seu passado maculado, sua Sanidade máxima inicial é reduzida pela metade.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Desgarrado,
            Nome = "Desgarrado",
            Descricao = "Você cresceu sem teto, nas ruas ou isolado na selva, aprendendo na prática como suportar as intempéries e resistir ao sofrimento.",
            PericiasTreinadas = new() { PericiasEnum.Fortitude, PericiasEnum.Sobrevivencia },
            PoderNome = "Calejado",
            PoderDescricao = "Você recebe +1 Ponto de Vida (PV) para cada 5% de NEX que possuir.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Engenheiro,
            Nome = "Engenheiro",
            Descricao = "Você projetava motores, edifícios ou redes industriais, e agora usa sua inteligência técnica para desmontar o inexplicável.",
            PericiasTreinadas = new() { PericiasEnum.Profissao, PericiasEnum.Tecnologia },
            PoderNome = "Ferramentas Favoritas",
            PoderDescricao = "Um item à sua escolha (exceto armas) tem sua categoria reduzida em I para você (por exemplo, de Categoria II para Categoria I).",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Executivo,
            Nome = "Executivo",
            Descricao = "Você gerenciava empresas ou corporações com foco em metas e burocracia até descobrir que o mundo corporativo não explicava tudo.",
            PericiasTreinadas = new() { PericiasEnum.Diplomacia, PericiasEnum.Profissao },
            PoderNome = "Processo Otimizado",
            PoderDescricao = "Sempre que faz um teste de perícia durante um teste estendido ou uma ação para revisar documentos, você pode gastar 2 PE para receber +5 nesse teste.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Investigador,
            Nome = "Investigador",
            Descricao = "Você era um detetive particular, perito criminal ou repórter investigativo acostumado a seguir pistas e desvendar mistérios.",
            PericiasTreinadas = new() { PericiasEnum.Investigacao, PericiasEnum.Percepcao },
            PoderNome = "Faro para Pistas",
            PoderDescricao = "Uma vez por cena, quando fizer um teste para procurar pistas ou investigar um local, você pode gastar 1 PE para receber +5 nesse teste.",
            CustoPe = 1,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Lutador,
            Nome = "Lutador",
            Descricao = "Você lutava em ringues, academias ou brigas de rua, transformando seu corpo e seus punhos em armas letais.",
            PericiasTreinadas = new() { PericiasEnum.Luta, PericiasEnum.Reflexos },
            PoderNome = "Mão Pesada",
            PoderDescricao = "Você recebe +2 em rolagens de dano com ataques corpo a corpo desarmados ou com armas leves.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Magnata,
            Nome = "Magnata",
            Descricao = "Você nasceu com fortuna herdada ou construiu um império financeiro, financiando operações que ninguém mais poderia pagar.",
            PericiasTreinadas = new() { PericiasEnum.Diplomacia, PericiasEnum.Pilotagem },
            PoderNome = "Patrocinador da Ordem",
            PoderDescricao = "Seu limite de crédito é sempre considerado uma categoria acima do atual determinado pela sua patente.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Mercenario,
            Nome = "Mercenário",
            Descricao = "Você atuava em companhias militares privadas ou como atirador contratado, lutando por dinheiro até encontrar perigos além do humano.",
            PericiasTreinadas = new() { PericiasEnum.Iniciativa, PericiasEnum.Pontaria },
            PoderNome = "Posição de Combate",
            PoderDescricao = "No primeiro turno de cada cena de ação, você pode gastar 2 PE para receber uma ação de movimento adicional.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Militar,
            Nome = "Militar",
            Descricao = "Você serviu no Exército, Marinha ou Aeronáutica, habituado à disciplina rígida e ao combate armado profissional.",
            PericiasTreinadas = new() { PericiasEnum.Pontaria, PericiasEnum.Tatica },
            PoderNome = "Para Bellum",
            PoderDescricao = "Você recebe +2 em rolagens de dano com armas de fogo.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Operario,
            Nome = "Operário",
            Descricao = "Você trabalhou com ferramentas pesadas em construções, oficinas ou minas, acostumado ao trabalho braçal árduo.",
            PericiasTreinadas = new() { PericiasEnum.Fortitude, PericiasEnum.Profissao },
            PoderNome = "Ferramenta de Trabalho",
            PoderDescricao = "Escolha uma arma simples ou tática corpo a corpo que o mestre aceite como ferramenta do seu antigo trabalho. Ela recebe +1 na margem de ameaça ou +1 nas rolagens de dano.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Policial,
            Nome = "Policial",
            Descricao = "Você atuou nas forças policiais mantendo a lei e a ordem nas ruas até que uma ocorrência revelou horrores inexplicáveis.",
            PericiasTreinadas = new() { PericiasEnum.Percepcao, PericiasEnum.Pontaria },
            PoderNome = "Patrulha",
            PoderDescricao = "Você recebe +2 em sua Defesa.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Religioso,
            Nome = "Religioso",
            Descricao = "Você encontrou refúgio e força na fé ou sacerdócio, confortando almas atormentadas pela escuridão do mundo.",
            PericiasTreinadas = new() { PericiasEnum.Religiao, PericiasEnum.Vontade },
            PoderNome = "Acalentar",
            PoderDescricao = "Você pode gastar uma ação padrão e 1 PE para usar a perícia Religião para acalmar um aliado adjacente abalado ou ajudá-lo a recuperar 1d6 de Sanidade.",
            CustoPe = 1,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.ServidorPublico,
            Nome = "Servidor Público",
            Descricao = "Você trabalhou na administração governamental ou em repartições públicas, servindo à comunidade e navegando pelas burocracias do Estado.",
            PericiasTreinadas = new() { PericiasEnum.Intuicao, PericiasEnum.Vontade },
            PoderNome = "Espírito Cívico",
            PoderDescricao = "Sempre que presta ajuda a outro personagem em um teste de perícia, você pode gastar 1 PE para aumentar o bônus concedido em +1d6.",
            CustoPe = 1,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.TeoricoDaConspiracao,
            Nome = "Teórico da Conspiração",
            Descricao = "Você sempre soube que acobertavam segredos sombrios. Todos riam das suas teorias... até você provar que estava certo.",
            PericiasTreinadas = new() { PericiasEnum.Investigacao, PericiasEnum.Ocultismo },
            PoderNome = "Eu Já Sabia",
            PoderDescricao = "Você recebe resistência a dano mental igual ao seu valor de Intelecto (RD Mental = INT).",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.TI,
            Nome = "T.I.",
            Descricao = "Você é programador, analista de sistemas ou especialista em segurança da informação habituado a minerar dados e quebrar senhas.",
            PericiasTreinadas = new() { PericiasEnum.Investigacao, PericiasEnum.Tecnologia },
            PoderNome = "Motor de Busca",
            PoderDescricao = "A critério do mestre, você pode gastar 2 PE para substituir qualquer teste de perícia baseado em Intelecto por um teste de Tecnologia ao realizar buscas por computadores ou rede.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.TrabalhadorRural,
            Nome = "Trabalhador Rural",
            Descricao = "Você cresceu e trabalhou no campo ou fazendas, lidando com animais, intempéries e os perigos rurais da natureza.",
            PericiasTreinadas = new() { PericiasEnum.Adestramento, PericiasEnum.Sobrevivencia },
            PoderNome = "Desbravador",
            PoderDescricao = "Você não sofre penalidade em deslocamento causada por terreno difícil e recebe +2 em testes de Adestramento e Sobrevivência.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Trambiqueiro,
            Nome = "Trambiqueiro",
            Descricao = "Você vivia de lábia, truques e pequenos golpes na rua até aplicar o golpe na pessoa errada e acabar recrutado pela Ordem.",
            PericiasTreinadas = new() { PericiasEnum.Crime, PericiasEnum.Enganacao },
            PoderNome = "Impostor",
            PoderDescricao = "Uma vez por cena, você pode gastar 2 PE para substituir qualquer teste de perícia social (como Diplomacia, Intimidação ou Intuição) por um teste de Enganação.",
            CustoPe = 2,
            EhPassivo = false
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Universitario,
            Nome = "Universitário",
            Descricao = "Você estava na faculdade estudando entre trabalhos e noites sem dormir até esbarrar em um segredo que mudou sua vida.",
            PericiasTreinadas = new() { PericiasEnum.Atualidades, PericiasEnum.Investigacao },
            PoderNome = "Dedicação",
            PoderDescricao = "Você recebe +1 Ponto de Esforço (PE) para cada 5% de NEX que possuir.",
            CustoPe = 0,
            EhPassivo = true
        },
        new OrigemDetalhes
        {
            Origem = OrigensEnum.Vitima,
            Nome = "Vítima",
            Descricao = "Você sobreviveu a uma manifestação paranormal devastadora. A dor e o medo deixaram cicatrizes permanentes, mas fortaleceram sua determinação.",
            PericiasTreinadas = new() { PericiasEnum.Reflexos, PericiasEnum.Vontade },
            PoderNome = "Cicatrizes Psicológicas",
            PoderDescricao = "Você recebe +1 Ponto de Sanidade (SAN) para cada 5% de NEX que possuir.",
            CustoPe = 0,
            EhPassivo = true
        }
    };

    public static IReadOnlyList<OrigemDetalhes> ObterTodas() => _origens.AsReadOnly();

    public static OrigemDetalhes? ObterPorOrigem(OrigensEnum origem) =>
        _origens.FirstOrDefault(o => o.Origem == origem);

    public static OrigemDetalhes? ObterPorId(int id) =>
        _origens.FirstOrDefault(o => (int)o.Origem == id);
}

using TavernaWeb.Domain.Catalogo;
using TavernaWeb.Domain.Enums.Ordem;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api/ordem/origens", () => Results.Ok(CatalogoOrigens.ObterTodas()))
   .WithName("ObterOrigensOrdem");

app.MapGet("/api/ordem/origens/{origem}", (OrigensEnum origem) =>
{
    var detalhe = CatalogoOrigens.ObterPorOrigem(origem);
    return detalhe is not null ? Results.Ok(detalhe) : Results.NotFound();
})
.WithName("ObterOrigemPorEnum");

app.Run();


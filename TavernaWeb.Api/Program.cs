using TavernaWeb.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMigrations(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.Run();


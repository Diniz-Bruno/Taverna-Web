using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavernaWeb.Domain.Enums.Ordem;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.EntityConfigurations;

public class OrdemConfiguration : IEntityTypeConfiguration<Ordem>
{
    public void Configure(EntityTypeBuilder<Ordem> builder)
    {
        // Nome da tabela
        builder.ToTable("FichaOrdem");

        // Chave Primária
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        // Dados Gerais
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.SubClasse)
            .HasMaxLength(100);

        // Status
        builder.Property(x => x.Nex)
            .IsRequired()
            .HasDefaultValue(5);

        builder.Property(x => x.Vida)
            .IsRequired();

        builder.Property(x => x.Pe)
            .IsRequired();

        // Enums (salvos como int no banco)
        builder.Property(x => x.Classe)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(x => x.Origem)
            .HasConversion<int>()
            .IsRequired();

        // Atributos
        builder.Property(x => x.Agilidade)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(x => x.Forca)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(x => x.Vigor)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(x => x.Inteligencia)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(x => x.Presenca)
            .IsRequired()
            .HasDefaultValue(0);

        // Coleções mapeadas como JSON
        builder.Property(x => x.Poderes)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions?)null) ?? new List<string>()
            );

        builder.Property(x => x.Pericias)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                v => JsonSerializer.Deserialize<Dictionary<PericiasEnum, int>>(v, (JsonSerializerOptions?)null) ?? new Dictionary<PericiasEnum, int>()
            );
    }
}

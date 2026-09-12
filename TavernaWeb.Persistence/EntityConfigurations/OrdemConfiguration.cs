using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.EntityConfigurations;

public class OrdemConfiguration : IEntityTypeConfiguration<Ordem>
{
    public void Configure(EntityTypeBuilder<Ordem> builder)
    {
        builder.ToTable("FichasOrdem");

        builder.HasKey(x => x.Idficha);
        builder.Property(x => x.Idficha)
        .ValueGeneratedNever();

        builder.HasOne<Ficha>()
        .WithOne()
        .HasForeignKey<Ordem>(x => x.Idficha)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Ignore(x => x.Sistema);

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
    }
}

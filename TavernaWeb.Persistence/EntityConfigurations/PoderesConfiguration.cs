using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.EntityConfigurations
{
    public class PoderesConfiguration : IEntityTypeConfiguration<Poderes>
    {
      public void Configure(EntityTypeBuilder<Poderes> builder)
        {
            builder.ToTable("Poderes");

            // Chave Primária
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            // Chave Estrangeira
            builder.HasOne<Ordem>()
                .WithMany(o => o.Poderes)
                .HasForeignKey(p => p.Idficha)
                .OnDelete(DeleteBehavior.Cascade);

            // Dados Gerais
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(420);

            builder.Property(x => x.Descricao)
                .HasMaxLength(500);

            builder.Property(x => x.CustoPe)
                .IsRequired()
                .HasDefaultValue(0);
        }
        
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.EntityConfigurations
{
    public class PericiaConfiguration : IEntityTypeConfiguration<Pericia>
    {
        public void Configure(EntityTypeBuilder<Pericia> builder)
        {
            builder.ToTable("Pericias");

            // Chave Primária
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            // Chave Estrangeira
            builder.HasOne<Ordem>()
                .WithMany(o => o.Pericias)
                .HasForeignKey(p => p.Idficha)
                .OnDelete(DeleteBehavior.Cascade);

            // Dados Gerais
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasConversion<int>();

            builder.Property(x => x.ValorBonus)
                .IsRequired()
                .HasDefaultValue(0);
        }
        
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TavernaWeb.Domain.Models;

namespace TavernaWeb.Persistence.EntityConfigurations
{
    public class FichaConfiguration: IEntityTypeConfiguration<Ficha>
    {
        public void Configure(EntityTypeBuilder<Ficha> builder)
        {
            builder.ToTable("Fichas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.IdUsuario)
                .IsRequired();
            builder.HasIndex(x => x.IdUsuario);

            builder.Property(x => x.Sistema)
                .HasConversion<int>()
                .IsRequired();

            builder.Property(x => x.CriadoEm)
                .IsRequired();
        }
    }
}
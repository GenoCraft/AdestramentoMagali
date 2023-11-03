using AdestramentoMagali.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdestramentoMagali.Repository.Mapping
{
    public class EquipamentoMap : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("Equipamento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Preco);

            builder.Property(prop => prop.Quantidade);

            builder.Property(prop => prop.DataCompra);

            builder.Property(prop => prop.UnidadeCachorro)
                .HasColumnType("varchar(10)");
        }
    }
}

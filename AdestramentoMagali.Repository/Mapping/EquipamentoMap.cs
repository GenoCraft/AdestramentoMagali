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

            builder.Property(prop => prop.Indicacao)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Quantidade);

            builder.Property(prop => prop.Descricao)
                .HasColumnType("varchar(200)");
        }
    }
}

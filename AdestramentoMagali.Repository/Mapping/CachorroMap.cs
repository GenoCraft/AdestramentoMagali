using AdestramentoMagali.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdestramentoMagali.Repository.Mapping
{
    public class CachorroMap : IEntityTypeConfiguration<Cachorro>
    {
        public void Configure(EntityTypeBuilder<Cachorro> builder)
        {
            builder.ToTable("Cachorro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .IsRequired();

            builder.Property(prop => prop.ValorTotal)
                .IsRequired();

            builder.HasOne(prop => prop.Cliente);

            builder.HasMany(prop => prop.Items);

        }
    }

    public class CachorroItemMap : IEntityTypeConfiguration<CachorroItem>
    {
        public void Configure(EntityTypeBuilder<CachorroItem> builder)
        {
            builder.ToTable("CachorroItem");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .IsRequired();

            builder.Property(prop => prop.ValorUnitario)
                .IsRequired();

            builder.Property(prop => prop.ValorTotal)
                .IsRequired();

            builder.HasOne(prop => prop.Cachorro);

        }
    }
}

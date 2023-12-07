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

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Idade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(prop => prop.Raca)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Sexo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Porte)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Peso)
                .IsRequired()
                .HasColumnType("decimal");

            builder.Property(prop => prop.Temperamento)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.TipoAdestramento)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Plano)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Funcionario);

            builder.HasOne(prop => prop.Cliente);

            builder.HasMany(prop => prop.Equipamentos)
                .WithOne(prop => prop.Cachorro)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
    public class CachorroEquipMap : IEntityTypeConfiguration<CachorroEquip>
    {
        public void Configure(EntityTypeBuilder<CachorroEquip> builder)
        {
            builder.ToTable("CachorroEquip");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Cachorro)
                .WithMany(prop => prop.Equipamentos)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

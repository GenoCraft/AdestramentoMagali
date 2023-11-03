using AdestramentoMagali.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdestramentoMagali.Repository.Mapping
{
    public class AdestradorMap : IEntityTypeConfiguration<Adestrador>
    {
        public void Configure(EntityTypeBuilder<Adestrador> builder)
        {
            builder.ToTable("Adestrador");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop!.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("mediumtext");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataCadastro)
                .HasDefaultValue(DateTime.Now);

            builder.Property(prop => prop.Especialidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Ativo);
        }

    }
}

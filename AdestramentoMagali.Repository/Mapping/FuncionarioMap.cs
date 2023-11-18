using AdestramentoMagali.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdestramentoMagali.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

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

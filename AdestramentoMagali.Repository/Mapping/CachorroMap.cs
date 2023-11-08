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

            builder.HasKey(prop => prop.Nome);

            builder.HasKey(prop => prop.Idade);

            builder.HasKey(prop => prop.Raca);

            builder.HasKey(prop => prop.Sexo);

            builder.HasKey(prop => prop.Porte);

            builder.HasKey(prop => prop.Peso);

            builder.HasKey(prop => prop.Temperamento);

            builder.HasKey(prop => prop.TipoAdestramento);

            builder.HasKey(prop => prop.Plano);

            builder.HasOne(prop => prop.Adestrador);

            builder.HasOne(prop => prop.Cliente);

            builder.HasMany(prop => prop.Equipamentos);

        }
    }
}

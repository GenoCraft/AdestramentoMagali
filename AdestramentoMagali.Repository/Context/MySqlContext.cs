using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace AdestramentoMagali.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Funcionario>? Funcionario { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Equipamento>? Equipamento { get; set; }
        public DbSet<Cachorro>? Cachorro { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);            
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Equipamento>(new EquipamentoMap().Configure);
            modelBuilder.Entity<Cachorro>(new CachorroMap().Configure);
        }
    }
}

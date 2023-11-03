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

        public DbSet<Adestrador>? Adestrador { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Equipamento>? Equipamento { get; set; }
        public DbSet<Cachorro>? Cachorro { get; set; }
        public DbSet<CachorroItem>? CachorroItem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Adestrador>(new AdestradorMap().Configure);            
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Equipamento>(new EquipamentoMap().Configure);
            modelBuilder.Entity<Cachorro>(new CachorroMap().Configure);
            modelBuilder.Entity<CachorroItem>(new CachorroItemMap().Configure);
        }
    }
}

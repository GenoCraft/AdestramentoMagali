using System.Text.Json;
using AdestramentoMagali.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdestramentoMagali.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Adestrador> Adestrador { get; set; }
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Equipamento> Equipamento { get; set; }
            public DbSet<Cachorro> Cachorro { get; set; }

            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "AdestramentoMagali";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }
        
        [TestMethod]
        public void TestInsertAdestradores()
        {
            using (var context = new MyDbContext())
            {

                var adestrador = new Adestrador
                {
                    Nome = "Murilo",
                    Email = "murilo@mail.com",
                    Senha = "123",
                    Telefone = 18991062431,
                    Especialidade = "Guarda",
                    DataCadastro = DateTime.Now
                };
                context.Adestrador.Add(adestrador);
                
                adestrador = new Adestrador
                {
                    Nome = "João",
                    Email = "joao@mail.com",
                    Senha = "123",
                    Telefone = 18991078901,
                    Especialidade = "Agility",
                    DataCadastro = DateTime.Now
                };
                context.Adestrador.Add(adestrador);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarAdestradores()
        {
            using (var context = new MyDbContext())
            {
                foreach (var adestrador in context.Adestrador)
                {
                    Console.WriteLine(JsonSerializer.Serialize(adestrador));
                }
            }
        }
    }
}
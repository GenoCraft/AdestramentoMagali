using System.Text.Json;
using AutoMapper;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Repository.Context;
using AdestramentoMagali.Repository.Repository;
using AdestramentoMagali.Service.Services;
using AdestramentoMagali.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AdestramentoMagali.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "AdestramentoMagali";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Funcionario, Funcionario>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestFuncionario()
        { 
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Funcionario>>();
            var funcionario = new Funcionario
            {
                Nome = "Murilo",
                Email = "murilo@mail.com",
                Senha = "123",
                Telefone = 18991062431,
                Especialidade = "Guarda",
                DataCadastro = DateTime.Now,
            };

            var result = _userService?.Add<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
using AutoMapper;
using AdestramentoMagali.App.Cadastros;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.Domain.Base;
using AdestramentoMagali.Domain.Entities;
using AdestramentoMagali.Repository.Context;
using AdestramentoMagali.Repository.Repository;
using AdestramentoMagali.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace AdestramentoMagali.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static  ServiceProvider? ServicesProvider;


        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                const string server = "localhost";
                const string port = "3306";
                const string database = "AdestramentoMagali";
                const string username = "root";
                const string password = "1122";
                const string strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Adestrador>, BaseRepository<Adestrador>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Equipamento>, BaseRepository<Equipamento>>();
            Services.AddScoped<IBaseRepository<Cachorro>, BaseRepository<Cachorro>>();

            // Services
            Services.AddScoped<IBaseService<Adestrador>, BaseService<Adestrador>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Equipamento>, BaseService<Equipamento>>();
            Services.AddScoped<IBaseService<Cachorro>, BaseService<Cachorro>>();

            // Formulários
            Services.AddTransient<CadastroAdestrador, CadastroAdestrador>();
            Services.AddTransient<CadastroEquipamento, CadastroEquipamento>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroCachorro, CadastroCachorro>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Adestrador, AdestradorModel>();
                config.CreateMap<Cidade, CidadeModel>()                    
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, 
                    d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Equipamento, EquipamentoModel>();
                config.CreateMap<Cachorro, CachorroModel>();

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

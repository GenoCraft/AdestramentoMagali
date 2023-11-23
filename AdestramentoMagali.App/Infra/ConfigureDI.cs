using AutoMapper;
using AdestramentoMagali.App.Cadastros;
using AdestramentoMagali.App.Models;
using AdestramentoMagali.App.Outros;
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
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });


            // Repositories
            Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Equipamento>, BaseRepository<Equipamento>>();
            Services.AddScoped<IBaseRepository<Cachorro>, BaseRepository<Cachorro>>();

            // Services
            Services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Equipamento>, BaseService<Equipamento>>();
            Services.AddScoped<IBaseService<Cachorro>, BaseService<Cachorro>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroFuncionario, CadastroFuncionario>();
            Services.AddTransient<CadastroEquipamento, CadastroEquipamento>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroCachorro, CadastroCachorro>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Funcionario, FuncionarioModel>();
                config.CreateMap<Cidade, CidadeModel>()                    
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Equipamento, EquipamentoModel>();
                config.CreateMap<Cachorro, CachorroModel>()
                    .ForMember(d => d.Funcionario, d => d.MapFrom(x => $"{x.Funcionario!.Nome}"))
                    .ForMember(d => d.IdFuncionario, d => d.MapFrom(x => x.Funcionario!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => $"{x.Cliente!.Nome}"))
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

using Business.Intefaces;
using BUSINESS.Interfaces;
using BUSINESS.Services;
using DATA.Context;
using DATA.Repository;
using DevIO.Business.Notificacoes;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace APP.Configuration
{

    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            services.AddScoped<MeuDbContext>();
            services.AddScoped<IAnuncioRepository, AnuncioRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ILojaRepository, LojaRepository>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IModeloRepository, ModeloRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<ISubCategoriaRepository, SubCategoriaRepository>();
            services.AddScoped<ITipoAnuncioRepository, TipoAnuncioRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IAnuncioService, AnuncioService>();
            return services;
        }
    }
}

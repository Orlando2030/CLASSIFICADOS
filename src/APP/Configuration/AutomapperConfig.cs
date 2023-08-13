using APP.ViewModels;
using AutoMapper;
using BUSINESS.Models;

namespace APP.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Anuncio, AnuncioViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
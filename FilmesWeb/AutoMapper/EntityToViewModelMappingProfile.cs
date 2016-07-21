using AutoMapper;
using Filmes_Bussines.Entities;
using FilmesWeb.ViewModels;

namespace FilmesWeb.AutoMapper
{
    public class EntityToViewModelMappingProfile:Profile
    {
      
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Diretor, DiretorViewModel>();
            CreateMap<Diretor, DiretorFilmeViewModel>();
            CreateMap<Filme, DiretorFilmeViewModel>();
            CreateMap<Filme, DiretorFilmeViewModel>();
        }

    }
}
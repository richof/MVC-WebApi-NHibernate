using AutoMapper;
using Filmes_Bussines.Entities;
using FilmesWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmesWeb.AutoMapper
{
    public class ViewModelToEntityMappingProfile:Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<DiretorViewModel, Diretor>();
            CreateMap<DiretorFilmeViewModel, Diretor>();
            CreateMap<FilmeViewModel, Filme>();
            CreateMap<DiretorFilmeViewModel, Filme>();
        }
    }
}
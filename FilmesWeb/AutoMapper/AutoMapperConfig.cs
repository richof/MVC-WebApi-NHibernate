using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmesWeb.AutoMapper
{
    public class AutoMapperConfig
    {
       public static void RegisterMappings()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<EntityToViewModelMappingProfile>();
                m.AddProfile<ViewModelToEntityMappingProfile>();
            });
        }
    }
}
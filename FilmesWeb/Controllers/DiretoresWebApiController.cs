using AutoMapper;
using Filmes_Bussines.Entities;
using Filmes_Bussines.Interfaces.Repository;
using FilmesWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FilmesWeb.Controllers
{
    public class DiretoresWebApiController : ApiController
    {
        private readonly IDiretorRepository _diretorRepository;
        public DiretoresWebApiController(IDiretorRepository diretorRepository)
        {
            _diretorRepository = diretorRepository;
        }
        // GET: api/Diretores
        public IEnumerable<DiretorViewModel> Get()
        {
            var diretores=Mapper.Map<IEnumerable<Diretor>,IEnumerable<DiretorViewModel>>( _diretorRepository.GetTodos().ToList());
            return diretores;
        }

        // GET: api/Diretores/5
        public DiretorViewModel Get(Guid id)
        {
        
            return MapearADiretorViewModel(_diretorRepository.GetPorId(id));
        }

        // POST: api/Diretores
        public void Post(DiretorViewModel diretorViewModel)
        {
            if (ModelState.IsValid)
            {
                _diretorRepository.Crear(MapearADiretor(diretorViewModel));
            }
            
        }

        // PUT: api/Diretores/5
        public void Put(DiretorViewModel diretorViewModel)
        {
            _diretorRepository.Atualizar(MapearADiretor(diretorViewModel));
        }

        // DELETE: api/Diretores/5
        public void Delete(int id)
        {
        }

        private DiretorViewModel MapearADiretorViewModel(Diretor diretor)
        {
            return Mapper.Map<Diretor, DiretorViewModel>(diretor);
        }
        private Diretor MapearADiretor(DiretorViewModel diretorViewModel)
        {
            return Mapper.Map<DiretorViewModel, Diretor>(diretorViewModel);
        }
    }
}

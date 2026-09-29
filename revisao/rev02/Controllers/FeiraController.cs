using Microsoft.AspNetCore.Mvc;
using rev02.Models;
using rev02.Repositories;

namespace rev02.Controllers
{
    [ApiController]
    [Route("")]
    public class FeiraController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IVisitaRepository _visitaRepository;

        public FeiraController(IProjetoRepository projetoRepository, IVisitaRepository visitaRepository)
        {
            _projetoRepository = projetoRepository;
            _visitaRepository = visitaRepository;
        }

        [HttpPost("Projetos")]
        public IActionResult CadastrarProjeto(Projeto projeto)
        {
            if (_projetoRepository.ObterPorNumero(projeto.NumeroProjeto) != null)
                return Conflict($"Já existe um projeto com o número {projeto.NumeroProjeto}.");

            _projetoRepository.Cadastrar(projeto);
            return Created(string.Empty, projeto);
        }

        [HttpGet("Projetos")]
        public IActionResult ListarProjetos()
        {
            return Ok(_projetoRepository.ObterTodos());
        }

        [HttpPost("Visitas")]
        public IActionResult RegistrarVisita(Visita visita)
        {
            if (_projetoRepository.ObterPorNumero(visita.NumeroProjeto) == null)
                return NotFound($"Não existe projeto com o número {visita.NumeroProjeto}.");

            _visitaRepository.Registrar(visita);
            return Created(string.Empty, visita);
        }

        [HttpGet("Visitas/{numeroProjeto}")]
        public IActionResult ConsultarVisitasPorProjeto(int numeroProjeto)
        {
            return Ok(_visitaRepository.ObterPorProjeto(numeroProjeto));
        }
    }
}
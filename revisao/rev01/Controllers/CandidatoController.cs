using Microsoft.AspNetCore.Mvc;
using rev01.Models;
using rev01.Repositories;

namespace rev01.Controllers
{
    [ApiController]
    [Route("")]
    public class EleicaoController : ControllerBase
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IVotoRepository _votoRepository;

        public EleicaoController(ICandidatoRepository candidatoRepository, IVotoRepository votoRepository)
        {
            _candidatoRepository = candidatoRepository;
            _votoRepository = votoRepository;
        }

        [HttpPost("Candidatos")]
        public IActionResult CadastrarCandidato(Candidato candidato)
        {
            if (_candidatoRepository.ObterPorNumeracao(candidato.NumeroCandidato) != null)
                return Conflict($"Já existe um candidato com o número {candidato.NumeroCandidato}.");

            _candidatoRepository.Cadastrar(candidato);
            return Created(string.Empty, candidato);
        }

        [HttpGet("Candidatos")]
        public IActionResult ListarCandidatos()
        {
            return Ok(_candidatoRepository.ObterTodos());
        }

        [HttpPost("Votos")]
        public IActionResult RegistrarVoto(Voto voto)
        {
            if (_candidatoRepository.ObterPorNumeracao(voto.NumeroCandidato) == null)
                return NotFound($"Não existe candidato com o número {voto.NumeroCandidato}.");

            _votoRepository.Registrar(voto);
            return Created(string.Empty, voto);
        }

        [HttpGet("Votos/{numeroCandidato}")]
        public IActionResult ConsultarVotosPorCandidato(int numeroCandidato)
        {
            return Ok(_votoRepository.ObterPorCandidato(numeroCandidato));
        }
    }
}
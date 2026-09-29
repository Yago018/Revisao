using rev01.Models;

namespace rev01.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private static List<Candidato> ListaCandidato = new List<Candidato>();

        public void Cadastrar(Candidato candidato)
        {
            ListaCandidato.Add(candidato);
        }

        public List<Candidato> ObterTodos()
        {
            return ListaCandidato;
        }

        public Candidato ObterPorNumeracao(int NumeroCandidato)
        {
            return ListaCandidato.FirstOrDefault(x => x.NumeroCandidato == NumeroCandidato);
        }
    }
}
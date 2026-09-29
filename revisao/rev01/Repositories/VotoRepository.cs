using rev01.Models;

namespace rev01.Repositories
{
    public class VotoRepository : IVotoRepository
    {
        private static readonly List<Voto> ListaVotos = new();

        public void Registrar(Voto voto)
        {
            ListaVotos.Add(voto);
        }

        public List<Voto> ObterPorCandidato(int numeroCandidato)
        {
            return ListaVotos.Where(v => v.NumeroCandidato == numeroCandidato).ToList();
        }
    }
}
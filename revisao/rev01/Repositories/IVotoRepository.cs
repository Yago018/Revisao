using rev01.Models;

namespace rev01.Repositories
{
    public interface IVotoRepository
    {
        void Registrar(Voto voto);
        List<Voto> ObterPorCandidato(int numeroCandidato);
    }
}
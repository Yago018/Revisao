using rev02.Models;

namespace rev02.Repositories
{
    public class VisitaRepository : IVisitaRepository
    {
        private static readonly List<Visita> ListaVisitas = new();

        public void Registrar(Visita visita)
        {
            ListaVisitas.Add(visita);
        }

        public List<Visita> ObterPorProjeto(int numeroProjeto)
        {
            return ListaVisitas.Where(v => v.NumeroProjeto == numeroProjeto).ToList();
        }
    }
}
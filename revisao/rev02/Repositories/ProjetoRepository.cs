using rev02.Models;

namespace rev02.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private static readonly List<Projeto> ListaProjetos = new();

        public void Cadastrar(Projeto projeto)
        {
            ListaProjetos.Add(projeto);
        }

        public List<Projeto> ObterTodos()
        {
            return ListaProjetos;
        }

        public Projeto? ObterPorNumero(int numeroProjeto)
        {
            return ListaProjetos.FirstOrDefault(p => p.NumeroProjeto == numeroProjeto);
        }
    }
}
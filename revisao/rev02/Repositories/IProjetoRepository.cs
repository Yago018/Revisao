using rev02.Models;

namespace rev02.Repositories
{
    public interface IProjetoRepository
    {
        void Cadastrar(Projeto projeto);
        List<Projeto> ObterTodos();
        Projeto? ObterPorNumero(int numeroProjeto);
    }
}
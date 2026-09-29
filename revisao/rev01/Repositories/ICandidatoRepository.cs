using rev01.Models;
namespace rev01.Repositories

{   
    public interface ICandidatoRepository
    {
        public void Cadastrar(Candidato candidato);
        public List<Candidato> ObterTodos();



        public Candidato ObterPorNumeracao(int NumeroCandidato);

    }
}
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Repositorio
{
    public interface IRotinaRepository
    {
        void Criar(Rotina rotinaNova);
        Rotina Obter(int id);
        void Atualizar(Rotina rotina);
        void Deletar(Rotina rotina);
        List<Rotina> ObterTodos();
    }
}

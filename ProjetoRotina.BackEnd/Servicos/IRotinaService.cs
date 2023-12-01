using ProjetoRotina.BackEnd.DTOS;
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Servicos
{
    public interface IRotinaService
    {
        void Criar(RotinaNovaDTO rotinaNova);
        Rotina Obter(int id);
        void Atualizar(Rotina rotina);
        void Deletar(int id);
        List<Rotina> ObterTodos();
    }
}

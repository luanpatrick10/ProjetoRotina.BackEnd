using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Servicos
{
    public interface IUsuarioService
    {
        void Criar(Usuario usuario);
        Usuario Obter(int id);
        void Atualizar(Usuario usuario);
        void Deletar(Usuario usuario);
        bool Logar(string email, string senha);
    }
}

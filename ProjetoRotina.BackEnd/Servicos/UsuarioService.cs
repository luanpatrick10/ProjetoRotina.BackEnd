using ProjetoRotina.BackEnd.DTOS;
using ProjetoRotina.BackEnd.Entidades;
using ProjetoRotina.BackEnd.Repositorio;

namespace ProjetoRotina.BackEnd.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Atualizar(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
        }

        public void Criar(Usuario usuario)
        {
            _usuarioRepository.Criar(usuario);
        }

        public void Deletar(Usuario usuario)
        {
            _usuarioRepository.Deletar(usuario);
        }

        public LogadoDTO Logar(string email, string senha)
        {
            return _usuarioRepository.LogarPorEmailESenha(email, senha);
        }

        public Usuario Obter(int id)
        {
            return _usuarioRepository.Obter(id);
        }


    }
}

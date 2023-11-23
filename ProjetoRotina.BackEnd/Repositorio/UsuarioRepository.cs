using Microsoft.EntityFrameworkCore;
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DbSet<Usuario> _dbSet;
        public UsuarioRepository(ApplicationContext applicationContext)
        {
            _dbSet = applicationContext.Set<Usuario>();
        }

        public void Atualizar(Usuario usuario)
        {
            _dbSet.Update(usuario);
        }

        public void Criar(Usuario usuario)
        {
            _dbSet.Add(usuario);
        }

        public void Deletar(Usuario usuario)
        {
            _dbSet.Remove(usuario);
        }

        public Usuario Obter(int id)
        {
            return _dbSet.Find(id);
        }

        public bool LogarPorEmailESenha(string email, string senha)
        {
            if (_dbSet.Where(usuario => usuario.Email == email && usuario.Senha == senha).Any())
                return true;
            return false;
        }
    }
}

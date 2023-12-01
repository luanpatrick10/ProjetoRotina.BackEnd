using Microsoft.EntityFrameworkCore;
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Repositorio
{
    public class RotinaRepository : IRotinaRepository
    {

        private DbSet<Rotina> _dbSet;
        private ApplicationContext _context;
        public RotinaRepository(ApplicationContext applicationContext)
        {
            _dbSet = applicationContext.Set<Rotina>();
            _context = applicationContext;
        }

        public void Atualizar(Rotina rotina)
        {
            _dbSet.Update(rotina);
            throw new NotImplementedException();
        }

        public void Criar(Rotina rotina)
        {
            _dbSet.Add(rotina);
            _context.SaveChanges();
        }

        public void Deletar(Rotina rotina)
        {
            _dbSet.Remove(rotina);
            _context.SaveChanges();
        }

        public Rotina Obter(int id)
        {
            return _dbSet.Find(id);
        }

        public List<Rotina> ObterTodos()
        {
            return _dbSet.ToList();
        }
    }
}

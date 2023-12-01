using ProjetoRotina.BackEnd.DTOS;
using ProjetoRotina.BackEnd.Entidades;
using ProjetoRotina.BackEnd.Repositorio;

namespace ProjetoRotina.BackEnd.Servicos
{
    public class RotinaService : IRotinaService
    {
        private readonly IRotinaRepository _rotinaRepository;
        public RotinaService(IRotinaRepository rotinaRepository)
        {
            _rotinaRepository = rotinaRepository;
        }

        public void Atualizar(Rotina rotina)
        {
            _rotinaRepository.Atualizar(rotina);
        }

        public void Criar(RotinaNovaDTO rotinaNova)
        {
            Rotina rotina = new Rotina();
            rotina.NomeDaRotina = rotinaNova.NomeDaRotina;
            rotina.DiasDaSemana = rotinaNova.DiasDaRotina;
            rotina.IdDoUsuario = rotinaNova.IdUsuario;
            _rotinaRepository.Criar(rotina);
        }

        public void Deletar(int id)
        {
            _rotinaRepository.Deletar(Obter(id));
        }

        public Rotina Obter(int id)
        {
            return _rotinaRepository.Obter(id);
        }

        public List<Rotina> ObterTodos()
        {
            return _rotinaRepository.ObterTodos();
        }
    }
}

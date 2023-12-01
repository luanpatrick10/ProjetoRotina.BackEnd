using Microsoft.AspNetCore.Mvc;
using ProjetoRotina.BackEnd.DTOS;
using ProjetoRotina.BackEnd.Entidades;
using ProjetoRotina.BackEnd.Servicos;

namespace ProjetoRotina.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotinaController : ControllerBase
    {
        private readonly IRotinaService _rotinaService;
        public RotinaController(IRotinaService rotinaService)
        {
            _rotinaService = rotinaService;
        }

        [HttpPost]
        [Route("criar")]
        public IActionResult Criar(RotinaNovaDTO novaRotina)
        {
            try
            {
                _rotinaService.Criar(novaRotina);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("obter-todos")]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(_rotinaService.ObterTodos());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet]
        [Route("obter-por-id")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                return Ok(_rotinaService.Obter(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpPatch]
        [Route("excluir")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _rotinaService.Deletar(id);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public IActionResult Atualizar(Rotina rotina)
        {
            try
            {
                _rotinaService.Atualizar(rotina);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProjetoRotina.BackEnd.Entidades;
using ProjetoRotina.BackEnd.Servicos;

namespace ProjetoRotina.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("logar/{email}/{senha}")]
        public IActionResult Logar(string email, string senha)
        {
            try
            {
                return Ok(_usuarioService.Logar(email, senha));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar([FromBody] Usuario usuario)
        {
            try
            {
                usuario.Id = 0;
                _usuarioService.Criar(usuario);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController] //Ja transformar em JSON!
    [Route("/api/")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository; //estanciar o repsotirory

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository; //define o repository que vier aqui para este controller
        }

        [HttpGet] //Task<ActioResult> é para receber o método Ok ou BadRequest, ele é sempre async e tem que ter um await, olhar o outro projeto
        public async Task<ActionResult<IEnumerable<Usuario>>> GetClientes()
        {
            return Ok(await _usuarioRepository.SelecionarTodos());
        }
    }
}

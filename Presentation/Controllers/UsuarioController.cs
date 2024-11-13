using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Services;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioDomainService _service;

        public UsuarioController(UsuarioDomainService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.Listar());
        }
    }
}

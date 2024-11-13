using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Services;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroDomainService _service;

        public LivroController(LivroDomainService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Livro livro)
        {
            try
            {
                _service.Cadastrar(livro);
                return Ok();
            }
            catch (DomainException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return Ok(_service.Listar());
        }
    }
}

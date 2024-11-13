using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Services;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoDomainService _service;

        public AlunoController(AlunoDomainService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Aluno aluno)
        {
            try
            {
                _service.Cadastrar(aluno);
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

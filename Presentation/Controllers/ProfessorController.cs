using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Services;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly ProfessorDomainService _service;

        public ProfessorController(ProfessorDomainService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Professor professor)
        {
            try
            {
                _service.Cadastrar(professor);
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

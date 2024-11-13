using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Services;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;
using SistemaBiblioteca.Presentation.ViewModels;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly EmprestimoDomainService _service;

        public EmprestimoController(EmprestimoDomainService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] CriarEmprestimoViewModel emprestimo)
        {
            try
            {
                _service.Cadastrar(emprestimo);
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

using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly Repository _repository;

        public ProfessorController()
        {
            _repository = Repository.GetRepository();
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Professor professor)
        {
            _repository.CadastrarProfessor(professor);
            return Ok();
        }
    }
}

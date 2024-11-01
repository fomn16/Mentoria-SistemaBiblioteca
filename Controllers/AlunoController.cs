using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly Repository _repository;

        public AlunoController()
        {
            _repository = Repository.GetRepository();
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Aluno aluno)
        {
            _repository.CadastrarAluno(aluno);
            return Ok();
        }
    }
}

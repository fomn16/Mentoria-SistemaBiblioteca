using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly Repository _repository;

        public LivroController()
        {
            _repository = Repository.GetRepository();
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Livro livro)
        {
            _repository.CadastrarLivro(livro);
            return Ok();
        }
    }
}

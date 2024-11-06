using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Repository _repository;

        public UsuarioController(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar() { 
            return Ok(_repository.ListarUsuarios());
        }
    }
}

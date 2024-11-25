using Microsoft.AspNetCore.Mvc;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArquivoController : ControllerBase
    {

        private readonly ArquivoRepository _repo;
        public ArquivoController(ArquivoRepository repo) {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult Upload(IFormFile arquivo, string nomeUsuario)
        {
            if (!arquivo.ContentType.Contains("pdf"))
            {
                return BadRequest("Só PDF");
            }
            var id = Guid.NewGuid().ToString("N");
            string path = nomeUsuario + "_" + id + "_" + arquivo.FileName;

            using (var stream = new FileStream("./Files/" + path, FileMode.Create))
            {
                arquivo.CopyTo(stream);
            }

            _repo.Cadastrar(new Arquivo
            {
                NomeArquivo = arquivo.FileName,
                NomeUsuario = nomeUsuario,
                Path = path
            });

            return Ok(id);
        }

        [HttpGet]
        public ActionResult Obter(string nomeUsuario, string idArquivo)
        {
            // implementar utilizando como base o código comentado abaixo

            /*
            Byte[] bytes;
            using (var stream = new FileStream("./Files/" + nome, FileMode.Open))
            {
                bytes = new byte[stream.Length];
                stream.Read(bytes);
            }

            return File(bytes, "application/pdf", nome);*/
            return Ok();
        }
    }
}

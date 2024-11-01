﻿using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly Repository _repository;

        public EmprestimoController()
        {
            _repository = Repository.GetRepository();
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody] Emprestimo emprestimo)
        {
            _repository.CadastrarEmprestimo(emprestimo);
            return Ok();
        }
    }
}

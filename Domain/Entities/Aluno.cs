using Microsoft.EntityFrameworkCore;

namespace SistemaBiblioteca.Domain.Entities
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace SistemaBiblioteca.Entities
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }
    }
}

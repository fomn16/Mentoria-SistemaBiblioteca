using SistemaBiblioteca.Domain.Entities;
using System.Runtime.CompilerServices;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class ProfessorRepository : RepositoryBase<Professor>
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context){}
    
        public bool Existe(string nome, string departamento)
        {
            return _context.Professores
                .Any(x =>   x.Nome == nome &&
                            x.Departamento == departamento);
        }
    }
}

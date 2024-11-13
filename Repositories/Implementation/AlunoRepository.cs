using SistemaBiblioteca.Domain.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class AlunoRepository : RepositoryBase<Aluno>
    {
        public AlunoRepository(ApplicationDbContext context) : base(context){}

        public bool Existe(string matricula)
        {
            return _context.Alunos
                .Any(x => x.Matricula == matricula);
        }
    }
}

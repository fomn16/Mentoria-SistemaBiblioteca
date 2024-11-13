using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Domain.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class EmprestimoRepository : RepositoryBase<Emprestimo>
    {
        public EmprestimoRepository(ApplicationDbContext context) : base(context){}
        
        public bool Existe(string nomeUsuario, string isbn)
        {
            return _context.Emprestimos
                .Any(x => x.Usuario.Nome == nomeUsuario &&
                            x.Livro.ISBN == isbn &&
                            x.DataDevolucao == null);
        }
        public override IEnumerable<Emprestimo> Listar()
        {
            return _context.Emprestimos
                .Include(x => x.Livro)
                .Include(x => x.Usuario)
                .ToList();
        }
    }
}

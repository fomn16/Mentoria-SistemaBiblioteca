using SistemaBiblioteca.Domain.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class LivroRepository : RepositoryBase<Livro>
    {
        public LivroRepository(ApplicationDbContext context) : base(context){}

        public Livro? Obter(string ISBN)
        {
            return _context.Livros
                .Where(x => x.ISBN == ISBN)
                .FirstOrDefault();
        }
    }
}

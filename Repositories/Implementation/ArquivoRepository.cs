using SistemaBiblioteca.Domain.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class ArquivoRepository : RepositoryBase<Arquivo>
    {
        public ArquivoRepository(ApplicationDbContext context) : base(context){}
    }
}

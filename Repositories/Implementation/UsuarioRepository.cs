using SistemaBiblioteca.Domain.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context){}

        public bool Existe(string nome)
        {
            return _context.Usuarios
                .Any(x => x.Nome == nome);
        }

        public Usuario? Obter(string nome)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> Listar()
        {
            return _context.Set<T>().ToList();
        }

        public virtual void Cadastrar(T registro)
        {
            _context.Set<T>().Add(registro);
            _context.SaveChanges();
        }
    }
}

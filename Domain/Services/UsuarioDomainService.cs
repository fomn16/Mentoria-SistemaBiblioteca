using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain.Services
{
    public class UsuarioDomainService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioDomainService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Usuario> Listar()
        {
            return _repository.Listar();
        }

        public bool Existe(string nome)
        {
            return _repository.Existe(nome);
        }
    }
}

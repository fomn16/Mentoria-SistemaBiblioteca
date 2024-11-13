using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain.Services
{
    public class ProfessorDomainService
    {
        private readonly ProfessorRepository _repository;
        private readonly UsuarioDomainService _usuarioDomain;

        public ProfessorDomainService(
            ProfessorRepository repository,
            UsuarioDomainService usuarioDomain)
        {
            _repository = repository;
            _usuarioDomain = usuarioDomain;
        }

        public void Cadastrar(Professor professor)
        {
            var ex = new DomainException();
            if (_usuarioDomain.Existe(professor.Nome))
            {
                ex.Error("Usuário já existe");
            }
            if (_repository.Existe(professor.Nome, professor.Departamento))
            {
                ex.Error("Professor já existe");
            }
            ex.ThrowIfError();
            _repository.Cadastrar(professor);
        }

        public IEnumerable<Professor> Listar()
        {
            return _repository.Listar();
        }
    }
}

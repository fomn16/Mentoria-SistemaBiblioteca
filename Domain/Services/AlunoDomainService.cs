using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain.Services
{
    public class AlunoDomainService
    {
        private readonly AlunoRepository _repository;
        private readonly UsuarioDomainService _usuarioDomain;
        public AlunoDomainService(
            AlunoRepository repository,
            UsuarioDomainService usuarioDomain)
        {
            _repository = repository;
            _usuarioDomain = usuarioDomain;
        }

        public void Cadastrar(Aluno aluno)
        {
            var ex = new DomainException();
            if (_usuarioDomain.Existe(aluno.Nome))
            {
                ex.Error("Usuário já existe");
            }
            if (_repository.Existe(aluno.Matricula))
            {
                ex.Error("Matrícula já cadastrada");
            }
            ex.ThrowIfError();

            _repository.Cadastrar(aluno);
        }

        public IEnumerable<Aluno> Listar()
        {
            return _repository.Listar();
        }
    }
}

using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Domain.Exceptions;
using SistemaBiblioteca.Presentation.ViewModels;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain.Services
{
    public class EmprestimoDomainService
    {
        private readonly EmprestimoRepository _repository;
        private readonly UsuarioRepository _usuarioRepository;
        private readonly LivroRepository _livroRepository;

        public EmprestimoDomainService(
            EmprestimoRepository repository,
            UsuarioRepository usuarioRepository,
            LivroRepository livroRepository)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _livroRepository = livroRepository;
        }

        public void Cadastrar(CriarEmprestimoViewModel emprestimo)
        {
            var ex = new DomainException();
            if (_repository.Existe(emprestimo.NomeUsuario, emprestimo.ISBN))
            {
                ex.Error("Usuário já pegou uma cópia deste livro emprestada");
            }
            var usuario = _usuarioRepository.Obter(emprestimo.NomeUsuario);
            if (usuario == null)
            {
                ex.Error("Usuário não encontrado");
            }
            var livro = _livroRepository.Obter(emprestimo.ISBN);
            if(livro == null)
            {
                ex.Error("Livro não encontrado");
            }
            ex.ThrowIfError();
            _repository.Cadastrar(new Emprestimo {
                Usuario = usuario!,
                Livro = livro!,
                DataEmprestimo = DateTime.Now
            });
        }

        public IEnumerable<Emprestimo> Listar()
        {
            return _repository.Listar();
        }
    }
}

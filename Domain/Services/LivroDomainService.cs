using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Domain.Entities;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain.Services
{
    public class LivroDomainService
    {
        private readonly LivroRepository _repository;

        public LivroDomainService(LivroRepository repository)
        {
            _repository = repository;
        }

        public void Cadastrar(
           Livro livro)
        {
            var livroExistente = _repository.Obter(livro.ISBN);
            if (livroExistente != null)
            {
                livroExistente.QuantidadeDisponivel += livro.QuantidadeDisponivel;
                _repository.SaveChanges();
            }
            else
            {
                _repository.Cadastrar(livro);
            }
        }

        public IEnumerable<Livro> Listar()
        {
            return _repository.Listar();
        }
    }
}

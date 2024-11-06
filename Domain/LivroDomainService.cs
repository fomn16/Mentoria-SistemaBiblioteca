using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Repositories.Implementation;

namespace SistemaBiblioteca.Domain
{
    public class LivroDomainService
    {
        private readonly Repository _repository;

        public LivroDomainService(Repository repository)
        {
            _repository = repository;
        }
        public void CadastrarLivro(
           Livro livro)
        {
            // regras de negócio
            var livroExistente = _repository.Obter(livro.ISBN);
            if(livroExistente != null)
            {
                livroExistente.QuantidadeDisponivel += livro.QuantidadeDisponivel;
                _repository.SaveChanges();
            }
            else
            {
                _repository.CadastrarLivro(livro);
            }
        }

        public IEnumerable<Livro> ListarLivros()
        {
            return _repository.ListarLivros();
        }
    }
}

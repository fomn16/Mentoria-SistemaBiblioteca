using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class Repository
    {
        private static Repository _repository = null;
        private List<Livro> _livros;

        private Repository()
        {
            _livros = new List<Livro>();
        }
        
        public static Repository GetRepository()
        {
            if(_repository == null)
            {
                _repository = new Repository();
            }
            return _repository;
        }

        public void CadastrarLivro(
            Livro livro)
        {
            _livros.Add(livro);
        }
    }
}

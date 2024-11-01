using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class Repository
    {
        private static Repository _repository = null;
        private List<Livro> _livros;
        private List<Aluno> _alunos;
        private List<Professor> _professores;
        private List<Emprestimo> _emprestimos;

        private Repository()
        {
            _livros = new List<Livro>();
            _alunos = new List<Aluno>();
            _professores = new List<Professor>();
            _emprestimos = new List<Emprestimo>();
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

        public void CadastrarAluno(
            Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public void CadastrarProfessor(
            Professor professor)
        {
            _professores.Add(professor);
        }

        public void CadastrarEmprestimo(
            Emprestimo emprestimo)
        {
            _emprestimos.Add(emprestimo);
        }
    }
}

using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Repositories.Implementation
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CadastrarLivro(
            Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Livro> ListarLivros()
        {
            return _context.Livros.ToList();
        }

        public Livro? Obter(string ISBN)
        {
            return _context.Livros
                .Where(x => x.ISBN == ISBN)
                .FirstOrDefault();
        }

        public void CadastrarAluno(
            Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public void CadastrarProfessor(
            Professor professor)
        {
            _context.Professores.Add(professor);
            _context.SaveChanges();
        }

        public void CadastrarEmprestimo(
            Emprestimo emprestimo)
        {
            _context.Emprestimos.Add(emprestimo);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> ListarUsuarios() {
            return _context.Usuarios.ToList();
        }
    }
}

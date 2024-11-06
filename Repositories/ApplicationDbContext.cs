using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos {  get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

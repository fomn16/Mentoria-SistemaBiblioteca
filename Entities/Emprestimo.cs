namespace SistemaBiblioteca.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

    }
}

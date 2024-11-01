namespace SistemaBiblioteca.Entities
{
    public class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public Emprestimo(
            Usuario usuario,
            Livro livro,
            DateTime dataEmprestimo) {

            Usuario = usuario;
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = null;
        }
    }
}

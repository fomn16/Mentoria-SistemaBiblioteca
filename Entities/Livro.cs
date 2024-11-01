namespace SistemaBiblioteca.Entities
{
    public class Livro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public Livro(string ISBN, string Titulo, string Autor, int AnoPublicacao, int QuantidadeDisponivel)
        {
            this.ISBN = ISBN;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.AnoPublicacao = AnoPublicacao;
            this.QuantidadeDisponivel = QuantidadeDisponivel;
        }
    }
}

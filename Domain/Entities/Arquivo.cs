namespace SistemaBiblioteca.Domain.Entities
{
    public class Arquivo
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; } = string.Empty;
        public string NomeUsuario { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
    }
}

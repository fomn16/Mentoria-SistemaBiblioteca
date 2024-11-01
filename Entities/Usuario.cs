namespace SistemaBiblioteca.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Usuario(string nome)
        {
            Id = Random.Shared.Next(0, int.MaxValue);
            Nome = nome;
        }
    }
}
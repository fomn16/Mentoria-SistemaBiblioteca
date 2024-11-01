namespace SistemaBiblioteca.Entities
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        // Utilizando o construtor em vez de especificar valor inicial na
        // declaração das propriedades
        public Aluno(string nome, string matricula, string curso) : base(nome)
        { 
            Matricula = matricula;
            Curso = curso;
        }
    }
}

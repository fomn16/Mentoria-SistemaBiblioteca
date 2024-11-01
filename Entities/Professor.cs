using System.Globalization;

namespace SistemaBiblioteca.Entities
{
    public class Professor : Usuario
    {
        public string Departamento { get; set; }
        public Professor(string nome, string departamento) : base(nome) {
            Departamento = departamento;
        }
    }
}

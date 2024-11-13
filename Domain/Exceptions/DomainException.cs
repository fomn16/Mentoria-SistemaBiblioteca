using System.Globalization;

namespace SistemaBiblioteca.Domain.Exceptions
{
    public class DomainException : Exception
    {
        private readonly List<string> excecoes = new List<string>();
        
        public DomainException() { }
        public DomainException(string ex)
        {
            excecoes.Add(ex);
        }

        public void Error(string ex)
        {
            excecoes.Add(ex);
        }

        public override string Message => string.Join(", ", excecoes);

        public void ThrowIfError()
        {
            if (excecoes.Any())
            {
                throw this;
            }
        }
    }
}

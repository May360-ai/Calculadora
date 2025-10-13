// Calculadora.Frontend/Models/RegistroCalculoDto.cs
namespace Calculadora.Frontend.Models
{
    public class RegistroCalculoDto
    {
        public int Id { get; set; }
        public string NombreDescriptivo { get; set; }
        public decimal Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
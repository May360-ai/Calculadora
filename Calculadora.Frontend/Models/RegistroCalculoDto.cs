// Calculadora.Frontend/Models/RegistroCalculoDto.cs
namespace Calculadora.Frontend.Models
{
    public class RegistroCalculoDto
    {
        public int Id { get; set; }
        public string NombreDescriptivo { get; set; } = string.Empty;
        public decimal Resultado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
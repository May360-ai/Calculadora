// Calculadora.Frontend/Models/GuardarRegistroRequest.cs
namespace Calculadora.Frontend.Models
{
    // Usamos un 'record' porque es ideal para objetos de transferencia de datos (DTOs)
    public record GuardarRegistroRequest(string NombreDescriptivo, decimal Resultado);
}
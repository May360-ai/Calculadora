// Calculadora.Frontend/Services/IRegistroService.cs
using Calculadora.Frontend.Models;

namespace Calculadora.Frontend.Services
{
    public interface IRegistroService
    {
        Task<List<RegistroCalculoDto>> ObtenerRegistrosAsync();
        Task GuardarRegistroAsync(GuardarRegistroRequest nuevoRegistro);
    }
}
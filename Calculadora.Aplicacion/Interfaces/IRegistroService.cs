using System.Collections.Generic;
using System.Threading.Tasks;
using Calculadora.Dominio.Entidades;

namespace Calculadora.Aplicacion.Interfaces
{
    public interface IRegistroService
    {
        Task<RegistroCalculo> GuardarCalculoAsync(string nombre, decimal resultado);
        Task<List<RegistroCalculo>> ObtenerRegistrosAsync();
    }
}

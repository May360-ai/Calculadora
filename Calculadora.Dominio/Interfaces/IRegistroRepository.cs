using System.Collections.Generic;
using System.Threading.Tasks;
using Calculadora.Dominio.Entidades;

namespace Calculadora.Dominio.Interfaces
{
    public interface IRegistroRepository
    {
        Task<RegistroCalculo> AgregarAsync(RegistroCalculo registro);
        Task<List<RegistroCalculo>> ObtenerTodosAsync();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calculadora.Dominio.Entidades;
using Calculadora.Dominio.Interfaces;
using Calculadora.Infraestructura.Contexto;

namespace Calculadora.Infraestructura.Persistencia
{
    public class RegistroRepository : IRegistroRepository
    {
        private readonly CalculadoraDbContext _contexto;

        public RegistroRepository(CalculadoraDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<RegistroCalculo> AgregarAsync(RegistroCalculo registro)
        {
            _contexto.Registros.Add(registro);
            await _contexto.SaveChangesAsync();
            return registro;
        }

        public async Task<List<RegistroCalculo>> ObtenerTodosAsync()
        {
            return await _contexto.Registros.ToListAsync();
        }
    }
}

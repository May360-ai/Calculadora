// Calculadora.Frontend/Services/RegistroServiceSimulado.cs
using Calculadora.Frontend.Models;

namespace Calculadora.Frontend.Services
{
    // Esta clase implementa la MISMA interfaz que el servicio real.
    // Para Blazor, es indistinguible de la versión real.
    public class RegistroServiceSimulado : IRegistroService
    {
        // Usamos una lista estática para que los datos no se borren entre interacciones,
        // solo cuando se reinicia la aplicación.
        private static List<RegistroCalculoDto> _registrosSimulados = new List<RegistroCalculoDto>
        {
            // Datos de ejemplo para que la lista no aparezca vacía al iniciar.
            new RegistroCalculoDto
            {
                Id = 1,
                NombreDescriptivo = "Ingresos de Enero (simulado)",
                Resultado = 2500.75m,
                FechaRegistro = DateTime.Now.AddDays(-30)
            },
            new RegistroCalculoDto
            {
                Id = 2,
                NombreDescriptivo = "Gastos de Supermercado (simulado)",
                Resultado = -150.50m,
                FechaRegistro = DateTime.Now.AddDays(-15)
            }
        };

        // Simula la obtención de todos los registros.
        public Task<List<RegistroCalculoDto>> ObtenerRegistrosAsync()
        {
            // Devolvemos una copia de la lista ordenada por fecha más reciente.
            var listaOrdenada = _registrosSimulados.OrderByDescending(r => r.FechaRegistro).ToList();
            
            // Task.FromResult envuelve nuestro resultado en una Tarea (Task) completada,
            // que es lo que la interfaz espera.
            return Task.FromResult(listaOrdenada);
        }

        // Simula el guardado de un nuevo registro.
        public Task GuardarRegistroAsync(GuardarRegistroRequest nuevoRegistro)
        {
            // Creamos un nuevo DTO a partir de la petición, como lo haría el backend.
            var nuevoDto = new RegistroCalculoDto
            {
                // Simulamos la creación de un nuevo ID.
                Id = _registrosSimulados.Any() ? _registrosSimulados.Max(r => r.Id) + 1 : 1,
                NombreDescriptivo = nuevoRegistro.NombreDescriptivo,
                Resultado = nuevoRegistro.Resultado,
                FechaRegistro = DateTime.Now
            };

            _registrosSimulados.Add(nuevoDto);

            // Devolvemos una Tarea completada, porque el método no devuelve ningún valor.
            return Task.CompletedTask;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculadora.Aplicacion.Interfaces;
using Calculadora.Dominio.Entidades;
using Calculadora.Dominio.Interfaces;

namespace Calculadora.Aplicacion.Servicios
{
    public class RegistroService : IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;

        public RegistroService(IRegistroRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }

        public async Task<RegistroCalculo> GuardarCalculoAsync(string nombre, decimal resultado)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre descriptivo es obligatorio.");
            }

            var nuevoRegistro = new RegistroCalculo
            {
                NombreDescriptivo = nombre,
                Resultado = resultado,
                FechaRegistro = DateTime.UtcNow
            };

            return await _registroRepository.AgregarAsync(nuevoRegistro);
        }

        public async Task<List<RegistroCalculo>> ObtenerRegistrosAsync()
        {
            return await _registroRepository.ObtenerTodosAsync();
        }
    }
}

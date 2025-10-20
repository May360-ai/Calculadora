using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Calculadora.Aplicacion.Interfaces;
using Calculadora.Dominio.Entidades;

namespace Calculadora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Ruta: /api/Registros
    public class RegistrosController : ControllerBase
    {
        private readonly IRegistroService _registroService;

        public RegistrosController(IRegistroService registroService)
        {
            _registroService = registroService;
        }

        public record GuardarRegistroRequest(string NombreDescriptivo, decimal Resultado);

        // POST /api/registros
        [HttpPost]
        public async Task<IActionResult> GuardarRegistro([FromBody] GuardarRegistroRequest request)
        {
            var registroGuardado = await _registroService.GuardarCalculoAsync(
                request.NombreDescriptivo,
                request.Resultado
            );

            return CreatedAtAction(nameof(ObtenerTodos), registroGuardado);
        }

        // GET /api/registros
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var registros = await _registroService.ObtenerRegistrosAsync();
            return Ok(registros);
        }
    }
}

// Calculadora.Frontend/Services/RegistroService.cs
using System.Net.Http.Json;
using Calculadora.Frontend.Models;

namespace Calculadora.Frontend.Services
{
    public class RegistroService : IRegistroService
    {
        private readonly HttpClient _httpClient;

        public RegistroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RegistroCalculoDto>> ObtenerRegistrosAsync()
        {
            // Llama al endpoint GET /api/registros
            return await _httpClient.GetFromJsonAsync<List<RegistroCalculoDto>>("api/registros");
        }

        public async Task GuardarRegistroAsync(GuardarRegistroRequest nuevoRegistro)
        {
            // Llama al endpoint POST /api/registros
            await _httpClient.PostAsJsonAsync("api/registros", nuevoRegistro);
        }
    }
}
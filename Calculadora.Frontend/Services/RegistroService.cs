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
           
            return await _httpClient.GetFromJsonAsync<List<RegistroCalculoDto>>("api/registros");
        }

        // PASO 2 (FRONTEND): Realiza la llamada HTTP POST al backend.
        // Envía los datos del nuevo registro a la WebAPI.
        public async Task GuardarRegistroAsync(GuardarRegistroRequest nuevoRegistro)
        {
            // Llama al PASO 3 en el backend
            await _httpClient.PostAsJsonAsync("api/registros", nuevoRegistro);
        }
    }
}
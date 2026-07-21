using System.Net.Http.Headers;
using System.Text.Json;
using ZiurPruebaTecnica.Models;

namespace ZiurPruebaTecnica.Services
{
    public class DocumentoService
    {
        private readonly HttpClient _httpClient;

        public DocumentoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Documento>> ObtenerDocumentos()
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "ae8bad44-7348-11ee-b962-0242ac120002");

                var respuesta = await _httpClient.GetAsync(
                    "https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos");

                // Lanza HttpRequestException si la API responde con un error HTTP (4xx o 5xx)
                respuesta.EnsureSuccessStatusCode();

                var json = await respuesta.Content.ReadAsStringAsync();

                var documentos = JsonSerializer.Deserialize<List<Documento>>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                return documentos ?? new List<Documento>();
            }
            catch (Exception)
            {
                // Re-lanzamos para que la UI de Blazor capture el error exacto
                throw;
            }
        }
    }
}
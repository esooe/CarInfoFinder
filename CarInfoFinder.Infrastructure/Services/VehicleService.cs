using CarInfoFinder.Application.Interfaces;
using CarInfoFinder.Domain.Entities;
using System.Net.Http.Json;
using System.Text.Json;

namespace CarInfoFinder.Infrastructure.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public VehicleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = "https://vpic.nhtsa.dot.gov/api/vehicles/";
        }

        public async Task<List<Make>> GetAllMakesAsync()
        {
            var res = await _httpClient.GetAsync($"{_baseUrl}getallmakes?format=json");
            res.EnsureSuccessStatusCode();

            var json = await res.Content.ReadFromJsonAsync<JsonElement>();
            return json.GetProperty("Results").Deserialize<List<Make>>()!;
        }

        public async Task<List<VehicleType>> GetVehicleTypesForMakeIdAsync(int makeId)
        {
            var url = $"{_baseUrl}GetVehicleTypesForMakeId/{makeId}?format=json";
            var res = await _httpClient.GetAsync(url);
            res.EnsureSuccessStatusCode();

            var json = await res.Content.ReadFromJsonAsync<JsonElement>();
            return json.GetProperty("Results").Deserialize<List<VehicleType>>()!;
        }

        public async Task<List<Model>> GetModelsForMakeIdYearAsync(int makeId, int year)
        {
            var url = $"{_baseUrl}GetModelsForMakeIdYear/makeId/ {makeId}/modelyear/{year}?format=json";
            var res = await _httpClient.GetAsync(url);
            res.EnsureSuccessStatusCode();
            var json = await res.Content.ReadFromJsonAsync<JsonElement>();
            return json.GetProperty("Results").Deserialize<List<Model>>()!;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dashboard.Shared.Http
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        // Backend URL'ini buraya veriyoruz. (Örn: https://localhost:5001/)
        public ApiClient(string baseAddress)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };

            // ASP.NET Core default ayarlarıyla uyumlu olması için camelCase kullanıyoruz
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();

                throw new ApiException(errorMessage, response.StatusCode);
            }

            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        // Create, Get gibi bir değer döndüren metotlar için dönüş tipi generic olarak belirtilecek. 
        public async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, data, _jsonOptions);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();

                throw new ApiException(errorMessage, response.StatusCode);
            }

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task PatchAsync<TRequest>(string endpoint, TRequest data)
        {
            var response = await _httpClient.PatchAsJsonAsync(endpoint, data, _jsonOptions);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new ApiException(errorMessage, response.StatusCode);
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var response = await _httpClient.PutAsJsonAsync(endpoint, data, _jsonOptions);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();

                throw new ApiException(errorMessage, response.StatusCode);
            }

            // Eğer response body boşsa hata vermemesi için kontrol
            if (response.Content.Headers.ContentLength == 0)
                return default;

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(endpoint);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();

                throw new ApiException(errorMessage, response.StatusCode);
            }
        }
    }
}
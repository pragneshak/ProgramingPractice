using System;
namespace JsonPlaceholderExample
{
	public class ApiService
	{
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> RetrieveDataFromApi(string apiUrl)
        {
            var response = await _httpClient.GetStringAsync(apiUrl);
            return response;
        }
    }
}


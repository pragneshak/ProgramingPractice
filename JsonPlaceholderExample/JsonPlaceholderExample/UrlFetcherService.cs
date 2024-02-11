using System;
namespace JsonPlaceholderExample
{
	public class UrlFetcherService
	{
        private readonly HttpClient _httpClient;

        public UrlFetcherService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<string[]> FetchUrlsAsync(int count)
        {
            var urls = new string[count];
            for (var i = 1; i <= count; i++)
            {
                var response = await _httpClient.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{i}");
                urls[i - 1] = response;
            }

            return urls;
        }
    }
}


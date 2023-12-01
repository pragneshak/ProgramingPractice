using System;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace SystemMonitorService
{
    public class TestService
    {
        private readonly List<string> _testUrls;
        private readonly IOptions<TestConfiguration> _configuration;

        public TestService(IOptions<TestConfiguration> configuration)
        {
            _configuration = configuration;
            _testUrls = _configuration.Value.TestUrls;
        }

        public async Task FetchAndPrintApiUrlsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = "https://jsonplaceholder.typicode.com/posts/10";
                var response = await httpClient.GetStringAsync(apiUrl);

                var apiUrls = JsonConvert.DeserializeObject<List<ApiModel>>(response);
                _testUrls.AddRange(apiUrls.Select(api => api.Url));

                // Print the fetched URLs
                foreach (var url in _testUrls)
                {
                    Console.WriteLine($"Fetched API URL: {url}");
                }
            }
        }
        private class ApiModel
        {
            public string Url { get; set; }
        }
    }
}

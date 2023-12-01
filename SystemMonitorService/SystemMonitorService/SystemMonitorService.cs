using System;
using System.Net;

namespace SystemMonitorService
{
	public class SystemMonitorService
	{
        private readonly List<EndpointInfo> _endpoints;
        private readonly HttpClient _httpClient;

        public SystemMonitorService(List<EndpointInfo> endpoints)
		{
            _endpoints = endpoints;
            _httpClient = new HttpClient();
        }
        public async Task MonitorEndpointsAsync()
        {
            foreach (var endpoint in _endpoints)
            {
                await MonitorEndpointAsync(endpoint);
            }
        }
        private async Task MonitorEndpointAsync(EndpointInfo endpoint)
        {
            try
            {
                var response = await _httpClient.GetAsync(endpoint.Url);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Endpoint {endpoint.Url} is healthy {response.StatusCode}");
                }
                else
                {
                    Console.WriteLine($"Endpoint {endpoint.Url} returned status code {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error monitoring {endpoint.Url}: {ex.Message}");
            }
        }
    }
}


using System.Net.Http;
using System.Threading.Tasks;
namespace JsonPlaceholderExample;
class Program
{
    static async Task Main()
    {
        //var httpClient = new HttpClient();
        //var urlFetcherService = new UrlFetcherService(httpClient);

        //try
        //{
        //    var urls = await urlFetcherService.FetchUrlsAsync(5);

        //    Console.WriteLine("Fetched URLs:");
        //    foreach (var url in urls)
        //    {
        //        Console.WriteLine(url);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"An error occurred: {ex.Message}");
        //}
        var apiUrl = "https://jsonplaceholder.typicode.com"; // Replace with your desired API URL
        var httpClient = new HttpClient();
        var apiService = new ApiService(httpClient);

        try
        {
            var apiData = await apiService.RetrieveDataFromApi(apiUrl);

            Console.WriteLine("Retrieved data:");
            Console.WriteLine(apiData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        
        finally
        {
            httpClient.Dispose();
        }
        Console.ReadKey();
    }
}

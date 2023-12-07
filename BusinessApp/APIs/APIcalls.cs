using System;
using System.Net.Http;
using System.Threading.Tasks;

public class CatFactApiCaller
{
    private readonly HttpClient _httpClient;

    public CatFactApiCaller()
    {
        _httpClient = new HttpClient();
    }

    public async Task PrintRandomCatFact()
    {
        try
        {
            string apiUrl = "https://catfact.ninja/fact";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

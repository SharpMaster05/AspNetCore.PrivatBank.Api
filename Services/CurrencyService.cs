using System.Text.Json;
using PrivatBank.Models;

namespace PrivatBank.Services;

public class CurrencyService
{
    private readonly HttpClient _client;

    public CurrencyService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<CurrencyRate>> GetAsync()
    {
        string url = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

        HttpResponseMessage response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();

        Console.WriteLine(json);

        return JsonSerializer.Deserialize<List<CurrencyRate>>(json) ?? throw new Exception();
    }
}

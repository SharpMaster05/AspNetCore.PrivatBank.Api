using System.Text.Json.Serialization;

namespace PrivatBank.Models;

public class CurrencyRate
{
    [JsonPropertyName("ccy")]
    public string Ccy { get; set; } = string.Empty;

    [JsonPropertyName("base_ccy")]
    public string BaseCcy { get; set; } = string.Empty;

    [JsonPropertyName("buy")]
    public string Buy { get; set; } = string.Empty;

    [JsonPropertyName("sale")]
    public string Sale { get; set; } = string.Empty;
}

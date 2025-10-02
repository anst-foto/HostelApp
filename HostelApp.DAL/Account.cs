using System.Text.Json.Serialization;

namespace HostelApp.DAL;

public record class Account
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("login")]
    public string Login { get; set; }
    
    [JsonPropertyName("password")]
    public string Password { get; set; }
}
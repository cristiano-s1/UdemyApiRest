namespace Udemy.Api.Data.VO;

public class PersonVO : ISupportsHyperMedia
{
    [JsonPropertyName("code")]
    public int Id { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    [JsonPropertyName("gender")]
    public string Gender { get; set; } = string.Empty;

    [JsonIgnore]
    public bool Enabled { get; set; }

    public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
}

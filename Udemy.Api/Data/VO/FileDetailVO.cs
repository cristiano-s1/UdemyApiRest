namespace Udemy.Api.Data.VO;

public class FileDetailVO
{
    [JsonPropertyName("document_name")]
    public string DocumentName { get; set; }  = string.Empty;  

    [JsonPropertyName("doc_type")]
    public string DocType { get; set; } = string.Empty;

    [JsonPropertyName("doc_url")]
    public string DocUrl { get; set; } = string.Empty;
}

using ApologistAiApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record CorpusSearchRequestFilters : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("ids")]
    public IEnumerable<int>? Ids { get; set; }

    [JsonPropertyName("types")]
    public IEnumerable<string>? Types { get; set; }

    [JsonPropertyName("languages")]
    public IEnumerable<string>? Languages { get; set; }

    [JsonPropertyName("collection_ids")]
    public IEnumerable<int>? CollectionIds { get; set; }

    [JsonPropertyName("contributor_ids")]
    public IEnumerable<int>? ContributorIds { get; set; }

    [JsonPropertyName("category_ids")]
    public IEnumerable<int>? CategoryIds { get; set; }

    [JsonPropertyName("classification_ids")]
    public IEnumerable<int>? ClassificationIds { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

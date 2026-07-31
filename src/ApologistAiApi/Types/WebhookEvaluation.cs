using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

/// <summary>
/// Result of an evaluation run for CTA/guardrail events.
/// </summary>
[Serializable]
public record WebhookEvaluation : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    [JsonPropertyName("score")]
    public double? Score { get; set; }

    [JsonPropertyName("passed")]
    public bool? Passed { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonIgnore]
    public AdditionalProperties AdditionalProperties { get; set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    void IJsonOnSerializing.OnSerializing() =>
        AdditionalProperties.CopyToExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

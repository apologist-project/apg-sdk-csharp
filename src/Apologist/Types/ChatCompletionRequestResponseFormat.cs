using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ChatCompletionRequestResponseFormat : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public ChatCompletionRequestResponseFormatType? Type { get; set; }

    /// <summary>
    /// Required when type is json_schema. Supplies the JSON Schema the structured output must conform to. Structured outputs are non-streaming.
    /// </summary>
    [JsonPropertyName("json_schema")]
    public ChatCompletionRequestResponseFormatJsonSchema? JsonSchema { get; set; }

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

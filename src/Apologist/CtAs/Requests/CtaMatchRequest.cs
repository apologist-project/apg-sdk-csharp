using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record CtaMatchRequest
{
    [JsonPropertyName("conversation")]
    public string? Conversation { get; set; }

    [JsonPropertyName("client")]
    public string? Client { get; set; }

    [JsonPropertyName("device")]
    public string? Device { get; set; }

    /// <summary>
    /// ISO language code, or `auto` to detect from the prompt.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Chat messages in OpenAI format.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<ChatMessage>? Messages { get; set; }

    [JsonPropertyName("session")]
    public string? Session { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    /// <summary>
    /// Flat string key/value pairs substituted into `{key}` placeholders in evaluator prompts run during CTA matching. Not persisted.
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, string?>? Variables { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

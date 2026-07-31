using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

/// <summary>
/// Canonical JSON body POSTed to a configured webhook URL. `notification`, `event`, and `agent` are always present; the remaining sections appear only when relevant to the event. Treat the payload as additive and ignore unrecognised fields.
/// </summary>
[Serializable]
public record WebhookPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("notification")]
    public required WebhookNotificationRef Notification { get; set; }

    [JsonPropertyName("event")]
    public required WebhookEventInfo Event { get; set; }

    [JsonPropertyName("agent")]
    public required WebhookAgentRef Agent { get; set; }

    /// <summary>
    /// Present when the event is tied to a prompt. Includes the prompt and response plus `automations` and `tags` arrays. Shape mirrors the prompt API object.
    /// </summary>
    [JsonPropertyName("completion")]
    public Dictionary<string, object?>? Completion { get; set; }

    /// <summary>
    /// Present when the prompt arrived via a channel.
    /// </summary>
    [JsonPropertyName("channel")]
    public WebhookNamedRef? Channel { get; set; }

    /// <summary>
    /// Present alongside `channel` when the channel has a platform.
    /// </summary>
    [JsonPropertyName("platform")]
    public WebhookNamedRef? Platform { get; set; }

    /// <summary>
    /// Present for cta_trigger and cta_click events.
    /// </summary>
    [JsonPropertyName("cta")]
    public WebhookCta? Cta { get; set; }

    /// <summary>
    /// Present for guardrail_trigger events.
    /// </summary>
    [JsonPropertyName("guardrail")]
    public WebhookNamedRef? Guardrail { get; set; }

    /// <summary>
    /// Present for CTA/guardrail events that ran an evaluation.
    /// </summary>
    [JsonPropertyName("evaluator")]
    public WebhookNamedRef? Evaluator { get; set; }

    [JsonPropertyName("evaluation")]
    public WebhookEvaluation? Evaluation { get; set; }

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

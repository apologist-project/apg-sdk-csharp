using Apologist.Core;
using global::System.Text.Json.Serialization;
using OneOf;

namespace Apologist;

[Serializable]
public record UserUpdateRequest
{
    /// <summary>
    /// The user's external id or internal id
    /// </summary>
    [JsonIgnore]
    public required string UserId { get; set; }

    /// <summary>
    /// Your external identifier for the user.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Applied tags as a mix of existing tag ids and/or default-language tag names. Unknown ids or names are rejected. Tags are mirror-owned and never created here.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<OneOf<string, int>>? Tags { get; set; }

    /// <summary>
    /// Responder to persist for this user on the requesting agent. Must be active on the agent.
    /// </summary>
    [JsonPropertyName("responder_id")]
    public int? ResponderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record PauseConversationRequest
{
    /// <summary>
    /// The conversation UUID or team-scoped external id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

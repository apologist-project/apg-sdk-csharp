using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record GetSharedMessagesRequest
{
    /// <summary>
    /// The share token
    /// </summary>
    [JsonIgnore]
    public required string Token { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

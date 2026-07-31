using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record VerifyFacebookWebhookRequest
{
    /// <summary>
    /// The channel id
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonIgnore]
    public required VerifyFacebookWebhookRequestHubMode HubMode { get; set; }

    [JsonIgnore]
    public required string HubVerifyToken { get; set; }

    [JsonIgnore]
    public string? HubChallenge { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

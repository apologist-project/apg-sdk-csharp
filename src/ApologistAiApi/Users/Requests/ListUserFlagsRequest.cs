using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record ListUserFlagsRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// Results per page (clamped to 100).
    /// </summary>
    [JsonIgnore]
    public int? PerPage { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

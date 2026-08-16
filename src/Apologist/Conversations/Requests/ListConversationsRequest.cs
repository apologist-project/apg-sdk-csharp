using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ListConversationsRequest
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

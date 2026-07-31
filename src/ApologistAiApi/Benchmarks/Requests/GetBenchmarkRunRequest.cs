using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record GetBenchmarkRunRequest
{
    /// <summary>
    /// The id or key of the benchmark
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// The id or UUID of the run
    /// </summary>
    [JsonIgnore]
    public required string RunId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

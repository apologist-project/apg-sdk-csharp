using Apologist.Core;
using global::System.Text.Json.Serialization;

namespace Apologist;

[Serializable]
public record ListEvaluationsRequest
{
    /// <summary>
    /// The ID or key of the evaluator
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// Results per page (clamped to 100).
    /// </summary>
    [JsonIgnore]
    public int? PerPage { get; set; }

    [JsonIgnore]
    public string? MinTimestamp { get; set; }

    [JsonIgnore]
    public string? MaxTimestamp { get; set; }

    [JsonIgnore]
    public string? MinDuration { get; set; }

    [JsonIgnore]
    public string? MaxDuration { get; set; }

    [JsonIgnore]
    public string? MinScore { get; set; }

    [JsonIgnore]
    public string? MaxScore { get; set; }

    [JsonIgnore]
    public string? Passed { get; set; }

    [JsonIgnore]
    public string? Benchmark { get; set; }

    [JsonIgnore]
    public string? BenchmarkRunId { get; set; }

    [JsonIgnore]
    public string? BenchmarkQuestionId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

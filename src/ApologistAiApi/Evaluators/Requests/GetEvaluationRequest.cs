using ApologistAiApi.Core;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[Serializable]
public record GetEvaluationRequest
{
    /// <summary>
    /// The id or key of the evaluator
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// The id or UUID of the evaluation
    /// </summary>
    [JsonIgnore]
    public required string EvaluationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

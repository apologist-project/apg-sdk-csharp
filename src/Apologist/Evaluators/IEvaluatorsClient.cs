namespace Apologist;

public partial interface IEvaluatorsClient
{
    /// <summary>
    /// Returns a paginated list of evaluations for the evaluator, scoped to the requesting agent.
    /// </summary>
    WithRawResponseTask<ListEvaluationsResponse> ListEvaluationsAsync(
        ListEvaluationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs an evaluation on the provided content using the specified evaluator
    /// </summary>
    WithRawResponseTask<EvaluateContentResponse> EvaluateContentAsync(
        EvaluatorRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single evaluation for the evaluator, scoped to the requesting agent.
    /// </summary>
    WithRawResponseTask<GetEvaluationResponse> GetEvaluationAsync(
        GetEvaluationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

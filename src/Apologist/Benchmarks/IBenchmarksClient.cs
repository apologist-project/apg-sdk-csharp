namespace Apologist;

public partial interface IBenchmarksClient
{
    /// <summary>
    /// Returns a paginated list of runs for a benchmark, scoped to the requesting agent. Each run carries nested evaluators, questions, and a flat evaluations array.
    /// </summary>
    WithRawResponseTask<ListBenchmarkRunsResponse> ListBenchmarkRunsAsync(
        ListBenchmarkRunsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Executes a benchmark run and returns the aggregated result with nested evaluators, questions, and a flat evaluations array.
    /// </summary>
    WithRawResponseTask<Dictionary<string, object?>> RunBenchmarkAsync(
        BenchmarkRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single benchmark run by id or UUID, scoped to the requesting agent, including nested evaluators, questions, and evaluations.
    /// </summary>
    WithRawResponseTask<GetBenchmarkRunResponse> GetBenchmarkRunAsync(
        GetBenchmarkRunRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

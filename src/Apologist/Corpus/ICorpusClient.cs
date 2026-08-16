namespace Apologist;

public partial interface ICorpusClient
{
    /// <summary>
    /// Performs a semantic search across the agent's corpus of knowledge
    /// </summary>
    WithRawResponseTask<SearchCorpusResponse> SearchCorpusAsync(
        CorpusSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records that a user viewed a specific corpus item
    /// </summary>
    WithRawResponseTask<SuccessResponse> LogCorpusViewAsync(
        ViewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records that a corpus item was shown to a user
    /// </summary>
    WithRawResponseTask<SuccessResponse> LogCorpusImpressionAsync(
        ImpressionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records a referral for a corpus item and, when a `url` is supplied, issues a 302 redirect to it. Without a `url`, responds with a success message. Requires either the search API entitlement or a signed `browser_key` cookie.
    /// </summary>
    WithRawResponseTask<SuccessResponse> LogCorpusReferralRedirectAsync(
        LogCorpusReferralRedirectRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records that a user was referred to a corpus item
    /// </summary>
    WithRawResponseTask<SuccessResponse> LogCorpusReferralAsync(
        ReferralRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

namespace Apologist;

public partial interface ICtAsClient
{
    /// <summary>
    /// Finds matching CTAs based on conversation context, user, session, device, or messages
    /// </summary>
    WithRawResponseTask<MatchCtasResponse> MatchCtasAsync(
        CtaMatchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records that a user clicked on a specific CTA
    /// </summary>
    WithRawResponseTask<SuccessResponse> LogCtaClickAsync(
        CtaClickRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

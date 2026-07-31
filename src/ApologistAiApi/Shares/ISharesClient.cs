namespace ApologistAiApi;

public partial interface ISharesClient
{
    /// <summary>
    /// Public, unauthenticated read of the messages behind a share token. The token is the bearer capability and enforces tenant isolation against the host agent. An empty or invalid token yields an empty messages array.
    /// </summary>
    WithRawResponseTask<GetSharedMessagesResponse> GetSharedMessagesAsync(
        GetSharedMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

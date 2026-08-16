namespace Apologist;

public partial interface IConversationsClient
{
    /// <summary>
    /// Returns a paginated list of conversations for the requesting agent, newest first.
    /// </summary>
    WithRawResponseTask<ListConversationsResponse> ListConversationsAsync(
        ListConversationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single conversation by internal UUID or team-scoped external id.
    /// </summary>
    WithRawResponseTask<GetConversationResponse> GetConversationAsync(
        GetConversationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Pauses the agent on a conversation identified by internal UUID or team-scoped external id. Requires an API key.
    /// </summary>
    WithRawResponseTask<PauseConversationResponse> PauseConversationAsync(
        PauseConversationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Resumes the agent on a conversation identified by internal UUID or team-scoped external id. Requires an API key.
    /// </summary>
    WithRawResponseTask<ResumeConversationResponse> ResumeConversationAsync(
        ResumeConversationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

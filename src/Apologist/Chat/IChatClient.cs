using OneOf;

namespace Apologist;

public partial interface IChatClient
{
    /// <summary>
    /// Returns a paginated list of chat completions (prompts) for the agent, with applied tags expanded as { id, name } and share metadata.
    /// </summary>
    WithRawResponseTask<ListChatCompletionsResponse> ListChatCompletionsAsync(
        ListChatCompletionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a chat completion using the agent's configured model. Supports both streaming and non-streaming responses.
    /// </summary>
    WithRawResponseTask<ChatCompletionResponse> CreateChatCompletionAsync(
        OneOf<object> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the like status of a specific chat completion
    /// </summary>
    WithRawResponseTask<SuccessResponse> LikeCompletionAsync(
        LikeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the flagged status of a specific chat completion
    /// </summary>
    WithRawResponseTask<SuccessResponse> FlagCompletionAsync(
        FlagRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds user feedback to a specific chat completion
    /// </summary>
    WithRawResponseTask<SuccessResponse> FeedbackCompletionAsync(
        FeedbackRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a share record for a specific chat completion
    /// </summary>
    WithRawResponseTask<SuccessResponse> ShareCompletionAsync(
        ShareRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single chat completion (prompt) by numeric id or UUID, including applied tags, guardrail/cta metadata, share metadata, and automation results.
    /// </summary>
    WithRawResponseTask<GetChatCompletionResponse> GetChatCompletionAsync(
        GetChatCompletionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

namespace Apologist;

public partial interface IAgentClient
{
    /// <summary>
    /// Pauses the agent globally and fans out pause transition messages to open conversations. Requires an API key.
    /// </summary>
    WithRawResponseTask<PauseAgentResponse> PauseAgentAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Resumes the agent globally and fans out resume transition messages to open conversations. Requires an API key.
    /// </summary>
    WithRawResponseTask<ResumeAgentResponse> ResumeAgentAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

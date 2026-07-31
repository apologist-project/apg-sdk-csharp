namespace Apologist;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ServiceUnavailableError(object body, Apologist.RawResponse? rawResponse = null)
    : ApologistAgentClientApiException(
        "ServiceUnavailableError",
        503,
        body,
        rawResponse: rawResponse
    );

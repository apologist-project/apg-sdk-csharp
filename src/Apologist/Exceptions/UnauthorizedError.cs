namespace Apologist;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnauthorizedError(object body, Apologist.RawResponse? rawResponse = null)
    : ApologistAgentClientApiException("UnauthorizedError", 401, body, rawResponse: rawResponse);

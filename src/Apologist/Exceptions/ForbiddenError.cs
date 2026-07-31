namespace Apologist;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ForbiddenError(object body, Apologist.RawResponse? rawResponse = null)
    : ApologistAgentClientApiException("ForbiddenError", 403, body, rawResponse: rawResponse);

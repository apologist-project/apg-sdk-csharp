namespace Apologist;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(object body, Apologist.RawResponse? rawResponse = null)
    : ApologistAgentClientApiException("NotFoundError", 404, body, rawResponse: rawResponse);

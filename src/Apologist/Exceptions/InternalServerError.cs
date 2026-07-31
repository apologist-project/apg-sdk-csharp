namespace Apologist;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InternalServerError(object body, Apologist.RawResponse? rawResponse = null)
    : ApologistAgentClientApiException("InternalServerError", 500, body, rawResponse: rawResponse);

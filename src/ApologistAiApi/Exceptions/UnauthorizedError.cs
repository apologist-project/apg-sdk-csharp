namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnauthorizedError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("UnauthorizedError", 401, body, rawResponse: rawResponse);

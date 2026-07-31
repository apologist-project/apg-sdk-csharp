namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ForbiddenError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("ForbiddenError", 403, body, rawResponse: rawResponse);

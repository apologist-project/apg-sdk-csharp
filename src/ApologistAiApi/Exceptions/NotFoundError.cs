namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("NotFoundError", 404, body, rawResponse: rawResponse);

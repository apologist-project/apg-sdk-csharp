namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InternalServerError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("InternalServerError", 500, body, rawResponse: rawResponse);

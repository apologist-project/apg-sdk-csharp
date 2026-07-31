namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ServiceUnavailableError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("ServiceUnavailableError", 503, body, rawResponse: rawResponse);

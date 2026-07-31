namespace ApologistAiApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadRequestError(object body, ApologistAiApi.RawResponse? rawResponse = null)
    : ApologistAiApiApiException("BadRequestError", 400, body, rawResponse: rawResponse);

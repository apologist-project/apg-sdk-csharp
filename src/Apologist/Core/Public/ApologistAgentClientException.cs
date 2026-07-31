namespace Apologist;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class ApologistAgentClientException(string message, Exception? innerException = null)
    : Exception(message, innerException);

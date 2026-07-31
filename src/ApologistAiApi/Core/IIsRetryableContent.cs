namespace ApologistAiApi.Core;

public interface IIsRetryableContent
{
    public bool IsRetryable { get; }
}

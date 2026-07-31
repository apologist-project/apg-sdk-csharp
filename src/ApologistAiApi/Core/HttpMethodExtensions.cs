using global::System.Net.Http;

namespace ApologistAiApi.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}

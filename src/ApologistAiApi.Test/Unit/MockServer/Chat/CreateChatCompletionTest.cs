using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Chat;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateChatCompletionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "key": "value"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "object": "object",
              "created": 1,
              "model": "model",
              "choices": [
                {
                  "index": 1,
                  "message": {
                    "role": "system",
                    "content": "content"
                  },
                  "logprobs": {
                    "logprobs": {
                      "key": "value"
                    }
                  },
                  "finish_reason": "finish_reason"
                },
                {
                  "index": 1,
                  "message": {
                    "role": "system",
                    "content": "content"
                  },
                  "logprobs": {
                    "logprobs": {
                      "key": "value"
                    }
                  },
                  "finish_reason": "finish_reason"
                }
              ],
              "usage": {
                "prompt_tokens": 1,
                "completion_tokens": 1,
                "total_tokens": 1
              },
              "cached": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/chat/completions")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Chat.CreateChatCompletionAsync(
            new Dictionary<object, object?>() { { "key", "value" } }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

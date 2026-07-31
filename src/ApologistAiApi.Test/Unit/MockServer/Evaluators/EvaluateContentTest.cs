using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Evaluators;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EvaluateContentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "content": "content"
            }
            """;

        const string mockResponse = """
            {
              "result": {
                "result": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/evaluators/id/evaluations")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Evaluators.EvaluateContentAsync(
            new EvaluatorRequest
            {
                Id = "id",
                FrequencyPenalty = null,
                ConfidenceThreshold = null,
                Content = "content",
                Model = null,
                PresencePenalty = null,
                ReasoningEffort = null,
                Verbosity = null,
                Temperature = null,
                TopP = null,
                Variables = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "content": "content"
            }
            """;

        const string mockResponse = """
            {
              "result": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/evaluators/id/evaluations")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Evaluators.EvaluateContentAsync(
            new EvaluatorRequest { Id = "id", Content = "content" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

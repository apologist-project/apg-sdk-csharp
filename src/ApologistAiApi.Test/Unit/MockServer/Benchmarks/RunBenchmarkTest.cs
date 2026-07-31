using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Benchmarks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RunBenchmarkTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "string": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/benchmarks/id/runs")
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

        var response = await Client.Benchmarks.RunBenchmarkAsync(
            new BenchmarkRunRequest
            {
                Id = "id",
                Content = null,
                CompletionId = null,
                SourceId = null,
                Model = null,
                NumResponses = null,
                UseQuestionVariants = null,
                ReasoningEffort = null,
                Verbosity = null,
                ScoreThreshold = null,
                ValueThreshold = null,
                Temperature = null,
                TopP = null,
                FrequencyPenalty = null,
                PresencePenalty = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "key": "value"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/benchmarks/id/runs")
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

        var response = await Client.Benchmarks.RunBenchmarkAsync(
            new BenchmarkRunRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

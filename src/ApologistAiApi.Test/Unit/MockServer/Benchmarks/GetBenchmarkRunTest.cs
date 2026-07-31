using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Benchmarks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetBenchmarkRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "data": {
                "data": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/benchmarks/id/runs/runId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Benchmarks.GetBenchmarkRunAsync(
            new GetBenchmarkRunRequest { Id = "id", RunId = "runId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "data": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/benchmarks/id/runs/runId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Benchmarks.GetBenchmarkRunAsync(
            new GetBenchmarkRunRequest { Id = "id", RunId = "runId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

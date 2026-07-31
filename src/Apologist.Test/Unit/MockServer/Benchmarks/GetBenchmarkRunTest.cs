using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Benchmarks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetBenchmarkRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
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

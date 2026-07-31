using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Benchmarks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListBenchmarkRunsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "key": "value"
                }
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/benchmarks/id/runs").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Benchmarks.ListBenchmarkRunsAsync(
            new ListBenchmarkRunsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Evaluators;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListEvaluationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "data": {
                    "key": "value"
                  }
                },
                {
                  "data": {
                    "key": "value"
                  }
                }
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/evaluators/id/evaluations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Evaluators.ListEvaluationsAsync(
            new ListEvaluationsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/evaluators/id/evaluations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Evaluators.ListEvaluationsAsync(
            new ListEvaluationsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

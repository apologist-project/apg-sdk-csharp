using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Evaluators;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EvaluateContentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
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

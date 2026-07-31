using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Evaluators;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetEvaluationTest : BaseMockServerTest
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
                    .WithPath("/evaluators/id/evaluations/evaluationId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Evaluators.GetEvaluationAsync(
            new GetEvaluationRequest { Id = "id", EvaluationId = "evaluationId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Agent;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResumeAgentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "is_paused": true,
                "paused_at": "paused_at",
                "resumed_at": "resumed_at",
                "emitted": 1,
                "skipped": 1
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/resume").UsingPost())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Agent.ResumeAgentAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}

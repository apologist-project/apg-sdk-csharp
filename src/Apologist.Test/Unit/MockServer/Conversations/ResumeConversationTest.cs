using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Conversations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResumeConversationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "external_id": "external_id",
                "agent_id": 1,
                "team_id": 1,
                "tags": {
                  "key": "value"
                },
                "started_at": "started_at",
                "ended_at": "ended_at",
                "agent_paused": true,
                "agent_paused_at": "agent_paused_at",
                "agent_resumed_at": "agent_resumed_at"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/conversations/id/resume")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Conversations.ResumeConversationAsync(
            new ResumeConversationRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

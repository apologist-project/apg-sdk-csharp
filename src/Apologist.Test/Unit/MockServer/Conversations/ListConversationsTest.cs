using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Conversations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListConversationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/conversations").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Conversations.ListConversationsAsync(
            new ListConversationsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

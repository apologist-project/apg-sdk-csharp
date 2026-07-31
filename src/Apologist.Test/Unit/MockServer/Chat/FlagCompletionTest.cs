using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Chat;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FlagCompletionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "flagged": true
            }
            """;

        const string mockResponse = """
            {
              "success": true,
              "message": "message"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/chat/completions/id/flag")
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

        var response = await Client.Chat.FlagCompletionAsync(
            new FlagRequest { Id = "id", Flagged = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

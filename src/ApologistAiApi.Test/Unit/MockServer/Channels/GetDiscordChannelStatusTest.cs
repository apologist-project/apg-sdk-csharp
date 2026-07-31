using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetDiscordChannelStatusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "status": "status",
              "channel": "channel",
              "active": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/discord")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Channels.GetDiscordChannelStatusAsync(
            new GetDiscordChannelStatusRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "status": "status",
              "channel": "channel",
              "active": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/discord")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Channels.GetDiscordChannelStatusAsync(
            new GetDiscordChannelStatusRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

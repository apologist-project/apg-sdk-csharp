using Apologist;
using Apologist.Test.Unit.MockServer;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveDiscordInteractionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "key": "value"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/discord")
                    .WithHeader("x-signature-ed25519", "x-signature-ed25519")
                    .WithHeader("x-signature-timestamp", "x-signature-timestamp")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveDiscordInteractionAsync(
                new ReceiveDiscordInteractionRequest
                {
                    Id = "id",
                    SignatureEd25519 = "x-signature-ed25519",
                    SignatureTimestamp = "x-signature-timestamp",
                    Body = new Dictionary<string, object?>() { { "key", "value" } },
                }
            )
        );
    }
}

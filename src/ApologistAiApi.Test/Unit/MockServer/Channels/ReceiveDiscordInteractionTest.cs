using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveDiscordInteractionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        const string requestJson = """
            {
              "string": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/discord")
                    .WithHeader("x-signature-ed25519", "signatureEd25519")
                    .WithHeader("x-signature-timestamp", "signatureTimestamp")
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
                    SignatureEd25519 = "signatureEd25519",
                    SignatureTimestamp = "signatureTimestamp",
                    Body = new Dictionary<string, object?>()
                    {
                        {
                            "string",
                            new Dictionary<object, object?>() { { "key", "value" } }
                        },
                    },
                }
            )
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
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

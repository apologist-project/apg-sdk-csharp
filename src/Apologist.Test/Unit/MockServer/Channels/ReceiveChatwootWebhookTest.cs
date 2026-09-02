using Apologist;
using Apologist.Test.Unit.MockServer;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveChatwootWebhookTest : BaseMockServerTest
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
                    .WithPath("/channels/id/chatwoot")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveChatwootWebhookAsync(
                new ReceiveChatwootWebhookRequest
                {
                    Id = "id",
                    Body = new Dictionary<string, object?>() { { "key", "value" } },
                }
            )
        );
    }
}

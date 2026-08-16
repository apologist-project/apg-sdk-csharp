using Apologist;
using Apologist.Test.Unit.MockServer;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VerifyWhatsAppWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = "string";

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/whatsapp")
                    .WithParam("hub.mode", "subscribe")
                    .WithParam("hub.verify_token", "hub.verify_token")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Channels.VerifyWhatsAppWebhookAsync(
            new VerifyWhatsAppWebhookRequest
            {
                Id = "id",
                HubMode = VerifyWhatsAppWebhookRequestHubMode.Subscribe,
                HubVerifyToken = "hub.verify_token",
            }
        );
        Assert.That(response, Is.EqualTo(mockResponse));
    }
}

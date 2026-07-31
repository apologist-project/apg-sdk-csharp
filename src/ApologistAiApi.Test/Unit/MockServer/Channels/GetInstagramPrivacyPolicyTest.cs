using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetInstagramPrivacyPolicyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = "string";

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/id/instagram/privacy")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Channels.GetInstagramPrivacyPolicyAsync(
            new GetInstagramPrivacyPolicyRequest { Id = "id" }
        );
        Assert.That(response, Is.EqualTo(mockResponse));
    }
}

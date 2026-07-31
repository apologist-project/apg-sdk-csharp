using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Shares;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSharedMessagesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "messages": [
                {
                  "key": "value"
                }
              ]
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/shares/token").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Shares.GetSharedMessagesAsync(
            new GetSharedMessagesRequest { Token = "token" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

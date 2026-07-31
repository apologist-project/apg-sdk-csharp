using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Chat;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListChatCompletionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "key": "value"
                }
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/chat/completions").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Chat.ListChatCompletionsAsync(new ListChatCompletionsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}

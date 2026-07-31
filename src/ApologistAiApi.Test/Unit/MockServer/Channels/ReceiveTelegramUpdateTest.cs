using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveTelegramUpdateTest : BaseMockServerTest
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
                    .WithPath("/channels/id/telegram")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveTelegramUpdateAsync(
                new ReceiveTelegramUpdateRequest
                {
                    Id = "id",
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
                    .WithPath("/channels/id/telegram")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveTelegramUpdateAsync(
                new ReceiveTelegramUpdateRequest
                {
                    Id = "id",
                    Body = new Dictionary<string, object?>() { { "key", "value" } },
                }
            )
        );
    }
}

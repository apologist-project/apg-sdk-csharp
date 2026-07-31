using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.CtAs;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LogCtaClickTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "prompt_id": "prompt_id"
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
                    .WithPath("/ctas/id/click")
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

        var response = await Client.CtAs.LogCtaClickAsync(
            new CtaClickRequest { Id = "id", PromptId = "prompt_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Corpus;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LogCorpusImpressionTest : BaseMockServerTest
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
                    .WithPath("/corpus/model/id/impression")
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

        var response = await Client.Corpus.LogCorpusImpressionAsync(
            new ImpressionRequest
            {
                Model = "model",
                Id = "id",
                PromptId = "prompt_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

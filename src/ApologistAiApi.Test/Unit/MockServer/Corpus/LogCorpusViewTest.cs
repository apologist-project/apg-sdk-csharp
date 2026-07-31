using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Corpus;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LogCorpusViewTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
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
                    .WithPath("/corpus/model/id/view")
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

        var response = await Client.Corpus.LogCorpusViewAsync(
            new ViewRequest
            {
                Model = "model",
                Id = "id",
                PromptId = "prompt_id",
                UserId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
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
                    .WithPath("/corpus/model/id/view")
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

        var response = await Client.Corpus.LogCorpusViewAsync(
            new ViewRequest
            {
                Model = "model",
                Id = "id",
                PromptId = "prompt_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

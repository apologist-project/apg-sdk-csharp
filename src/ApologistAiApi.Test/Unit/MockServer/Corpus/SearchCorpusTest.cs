using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Corpus;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SearchCorpusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "query": "query"
            }
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "results": {
                    "key": "value"
                  }
                },
                {
                  "results": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/corpus/search")
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

        var response = await Client.Corpus.SearchCorpusAsync(
            new CorpusSearchRequest
            {
                Query = "query",
                PromptId = null,
                Limit = null,
                Filters = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "query": "query"
            }
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "key": "value"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/corpus/search")
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

        var response = await Client.Corpus.SearchCorpusAsync(
            new CorpusSearchRequest { Query = "query" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Corpus;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SearchCorpusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
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

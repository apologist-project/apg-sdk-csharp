using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Corpus;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LogCorpusReferralTest : BaseMockServerTest
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
                    .WithPath("/corpus/model/id/referral")
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

        var response = await Client.Corpus.LogCorpusReferralAsync(
            new ReferralRequest
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
                    .WithPath("/corpus/model/id/referral")
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

        var response = await Client.Corpus.LogCorpusReferralAsync(
            new ReferralRequest
            {
                Model = "model",
                Id = "id",
                PromptId = "prompt_id",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

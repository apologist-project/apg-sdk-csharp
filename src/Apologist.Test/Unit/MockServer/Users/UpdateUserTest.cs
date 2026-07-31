using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Users;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "external_id": "external_id",
                "team_id": 1,
                "created_at": "created_at",
                "migrated_at": "migrated_at",
                "migrated_to_user_id": "migrated_to_user_id",
                "tags": [
                  {
                    "id": 1,
                    "name": "name"
                  },
                  {
                    "id": 1,
                    "name": "name"
                  }
                ],
                "responder_id": 1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/users/user_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.UpdateUserAsync(
            new UserUpdateRequest
            {
                UserId = "user_id",
                ExternalId = null,
                Tags = null,
                ResponderId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "id",
                "external_id": "external_id",
                "team_id": 1,
                "created_at": "created_at",
                "migrated_at": "migrated_at",
                "migrated_to_user_id": "migrated_to_user_id",
                "tags": [
                  {}
                ],
                "responder_id": 1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/users/user_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.UpdateUserAsync(
            new UserUpdateRequest { UserId = "user_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}

using ApologistAiApi;
using ApologistAiApi.Test.Unit.MockServer;
using ApologistAiApi.Test.Utils;
using NUnit.Framework;

namespace ApologistAiApi.Test.Unit.MockServer.Users;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListUsersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
                },
                {
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
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.ListUsersAsync(new ListUsersRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.ListUsersAsync(new ListUsersRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}

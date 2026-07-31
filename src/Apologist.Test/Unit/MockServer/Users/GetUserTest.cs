using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Users;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/user_id").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.GetUserAsync(new GetUserRequest { UserId = "user_id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}

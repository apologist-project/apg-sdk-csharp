using Apologist;
using Apologist.Test.Unit.MockServer;
using Apologist.Test.Utils;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Users;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListUserFlagsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": 1,
                  "name": "name",
                  "user_id": 1,
                  "team_id": 1,
                  "synced_at": "synced_at"
                },
                {
                  "id": 1,
                  "name": "name",
                  "user_id": 1,
                  "team_id": 1,
                  "synced_at": "synced_at"
                }
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/flags").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.ListUserFlagsAsync(new ListUserFlagsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": 1,
                  "name": "name",
                  "user_id": 1,
                  "team_id": 1,
                  "synced_at": "synced_at"
                }
              ],
              "total": 1,
              "page": 1,
              "per_page": 1
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/flags").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.ListUserFlagsAsync(new ListUserFlagsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}

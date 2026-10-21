using Apologist;
using Apologist.Test.Unit.MockServer;
using NUnit.Framework;

namespace Apologist.Test.Unit.MockServer.Channels;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveChatwootWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        const string requestJson = """
            {
              "event": "message_created",
              "id": 9001,
              "content": "Hello from Messenger",
              "message_type": "incoming",
              "private": false,
              "account": {
                "id": 7
              },
              "sender": {
                "id": 55,
                "name": "Pat",
                "type": "contact"
              },
              "conversation": {
                "id": 42,
                "status": "pending",
                "account": {
                  "id": 7
                },
                "meta": {
                  "assignee_type": "AgentBot",
                  "sender": {
                    "id": 55,
                    "name": "Pat"
                  }
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/91/chatwoot")
                    .WithHeader(
                        "X-Chatwoot-Signature",
                        "sha256=2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824"
                    )
                    .WithHeader("X-Chatwoot-Timestamp", "1710000000")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveChatwootWebhookAsync(
                new ChatwootWebhookPayload
                {
                    ChannelId = "91",
                    ChatwootSignature =
                        "sha256=2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824",
                    ChatwootTimestamp = "1710000000",
                    Event = "message_created",
                    Id = 9001,
                    Content = "Hello from Messenger",
                    MessageType = "incoming",
                    Private = false,
                    Account = new ChatwootWebhookPayloadAccount { Id = 7 },
                    Sender = new ChatwootWebhookPayloadSender
                    {
                        Id = 55,
                        Name = "Pat",
                        Type = "contact",
                    },
                    Conversation = new ChatwootWebhookPayloadConversation
                    {
                        Id = 42,
                        Status = "pending",
                        Account = new ChatwootWebhookPayloadConversationAccount { Id = 7 },
                        Meta = new ChatwootConversationMeta
                        {
                            AssigneeType = "AgentBot",
                            Sender = new ChatwootConversationMetaSender { Id = 55, Name = "Pat" },
                        },
                    },
                }
            )
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        const string requestJson = """
            {
              "event": "conversation_opened",
              "id": 42,
              "status": "open",
              "account": {
                "id": 7
              },
              "meta": {
                "assignee_type": "User",
                "sender": {
                  "id": 55,
                  "name": "Pat"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/channels/91/chatwoot")
                    .WithHeader(
                        "X-Chatwoot-Signature",
                        "sha256=2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824"
                    )
                    .WithHeader("X-Chatwoot-Timestamp", "1710000000")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Channels.ReceiveChatwootWebhookAsync(
                new ChatwootWebhookPayload
                {
                    ChannelId = "91",
                    ChatwootSignature =
                        "sha256=2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824",
                    ChatwootTimestamp = "1710000000",
                    Event = "conversation_opened",
                    Id = 42,
                    Status = "open",
                    Account = new ChatwootWebhookPayloadAccount { Id = 7 },
                    Meta = new ChatwootConversationMeta
                    {
                        AssigneeType = "User",
                        Sender = new ChatwootConversationMetaSender { Id = 55, Name = "Pat" },
                    },
                }
            )
        );
    }
}

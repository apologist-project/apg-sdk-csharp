# Reference
## Chat
<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">ListChatCompletionsAsync</a>(ListChatCompletionsRequest { ... }) -> WithRawResponseTask&lt;ListChatCompletionsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of chat completions (prompts) for the agent, with applied tags expanded as { id, name } and share metadata.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.ListChatCompletionsAsync(new ListChatCompletionsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListChatCompletionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">CreateChatCompletionAsync</a>(OneOf&lt;object&gt; { ... }) -> WithRawResponseTask&lt;ChatCompletionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a chat completion using the agent's configured model. Supports both streaming and non-streaming responses.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.CreateChatCompletionAsync(
    new Dictionary<object, object?>() { { "key", "value" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OneOf<object>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">LikeCompletionAsync</a>(LikeRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the like status of a specific chat completion
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.LikeCompletionAsync(new LikeRequest { Id = "id", Liked = true });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LikeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">FlagCompletionAsync</a>(FlagRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the flagged status of a specific chat completion
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.FlagCompletionAsync(new FlagRequest { Id = "id", Flagged = true });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FlagRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">FeedbackCompletionAsync</a>(FeedbackRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds user feedback to a specific chat completion
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.FeedbackCompletionAsync(new FeedbackRequest { Id = "id", Feedback = "feedback" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeedbackRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">ShareCompletionAsync</a>(ShareRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a share record for a specific chat completion
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.ShareCompletionAsync(new ShareRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ShareRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Chat.<a href="/src/Apologist/Chat/ChatClient.cs">GetChatCompletionAsync</a>(GetChatCompletionRequest { ... }) -> WithRawResponseTask&lt;GetChatCompletionResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single chat completion (prompt) by numeric id or UUID, including applied tags, guardrail/cta metadata, share metadata, and automation results.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Chat.GetChatCompletionAsync(new GetChatCompletionRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetChatCompletionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Corpus
<details><summary><code>client.Corpus.<a href="/src/Apologist/Corpus/CorpusClient.cs">SearchCorpusAsync</a>(CorpusSearchRequest { ... }) -> WithRawResponseTask&lt;SearchCorpusResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Performs a semantic search across the agent's corpus of knowledge
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Corpus.SearchCorpusAsync(new CorpusSearchRequest { Query = "query" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CorpusSearchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Corpus.<a href="/src/Apologist/Corpus/CorpusClient.cs">LogCorpusViewAsync</a>(ViewRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records that a user viewed a specific corpus item
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Corpus.LogCorpusViewAsync(
    new ViewRequest
    {
        Model = "model",
        Id = "id",
        PromptId = "prompt_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ViewRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Corpus.<a href="/src/Apologist/Corpus/CorpusClient.cs">LogCorpusImpressionAsync</a>(ImpressionRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records that a corpus item was shown to a user
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Corpus.LogCorpusImpressionAsync(
    new ImpressionRequest
    {
        Model = "model",
        Id = "id",
        PromptId = "prompt_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImpressionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Corpus.<a href="/src/Apologist/Corpus/CorpusClient.cs">LogCorpusReferralRedirectAsync</a>(LogCorpusReferralRedirectRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records a referral for a corpus item and, when a `url` is supplied, issues a 302 redirect to it. Without a `url`, responds with a success message. Requires either the search API entitlement or a signed `browser_key` cookie.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Corpus.LogCorpusReferralRedirectAsync(
    new LogCorpusReferralRedirectRequest
    {
        Model = "model",
        Id = "id",
        PromptId = "prompt_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LogCorpusReferralRedirectRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Corpus.<a href="/src/Apologist/Corpus/CorpusClient.cs">LogCorpusReferralAsync</a>(ReferralRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records that a user was referred to a corpus item
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Corpus.LogCorpusReferralAsync(
    new ReferralRequest
    {
        Model = "model",
        Id = "id",
        PromptId = "prompt_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReferralRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Evaluators
<details><summary><code>client.Evaluators.<a href="/src/Apologist/Evaluators/EvaluatorsClient.cs">ListEvaluationsAsync</a>(ListEvaluationsRequest { ... }) -> WithRawResponseTask&lt;ListEvaluationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of evaluations for the evaluator, scoped to the requesting agent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Evaluators.ListEvaluationsAsync(new ListEvaluationsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListEvaluationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Evaluators.<a href="/src/Apologist/Evaluators/EvaluatorsClient.cs">EvaluateContentAsync</a>(EvaluatorRequest { ... }) -> WithRawResponseTask&lt;EvaluateContentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Runs an evaluation on the provided content using the specified evaluator
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Evaluators.EvaluateContentAsync(
    new EvaluatorRequest { Id = "id", Content = "content" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EvaluatorRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Evaluators.<a href="/src/Apologist/Evaluators/EvaluatorsClient.cs">GetEvaluationAsync</a>(GetEvaluationRequest { ... }) -> WithRawResponseTask&lt;GetEvaluationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single evaluation for the evaluator, scoped to the requesting agent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Evaluators.GetEvaluationAsync(
    new GetEvaluationRequest { Id = "id", EvaluationId = "evaluationId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetEvaluationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## CTAs
<details><summary><code>client.CtAs.<a href="/src/Apologist/CtAs/CtAsClient.cs">MatchCtasAsync</a>(OneOf&lt;object&gt; { ... }) -> WithRawResponseTask&lt;MatchCtasResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Finds matching CTAs based on conversation context, user, session, device, or messages
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CtAs.MatchCtasAsync(new Dictionary<object, object?>() { { "key", "value" } });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OneOf<object>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CtAs.<a href="/src/Apologist/CtAs/CtAsClient.cs">LogCtaClickAsync</a>(CtaClickRequest { ... }) -> WithRawResponseTask&lt;SuccessResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Records that a user clicked on a specific CTA
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CtAs.LogCtaClickAsync(new CtaClickRequest { Id = "id", PromptId = "prompt_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CtaClickRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Users
<details><summary><code>client.Users.<a href="/src/Apologist/Users/UsersClient.cs">ListUsersAsync</a>(ListUsersRequest { ... }) -> WithRawResponseTask&lt;ListUsersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of users for the agent's team, with applied tags expanded as { id, name } and the persisted responder id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListUsersAsync(new ListUsersRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Apologist/Users/UsersClient.cs">ListUserFlagsAsync</a>(ListUserFlagsRequest { ... }) -> WithRawResponseTask&lt;ListUserFlagsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of user flag definitions for the agent's team (all columns from user_flags), ordered by id ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListUserFlagsAsync(new ListUserFlagsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListUserFlagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Apologist/Users/UsersClient.cs">GetUserAsync</a>(GetUserRequest { ... }) -> WithRawResponseTask&lt;GetUserResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single user by external id or internal id, with expanded tags and the persisted responder for the agent.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.GetUserAsync(new GetUserRequest { UserId = "user_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUserRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Apologist/Users/UsersClient.cs">UpdateUserAsync</a>(UserUpdateRequest { ... }) -> WithRawResponseTask&lt;UpdateUserResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a user's external_id and/or tags and upserts the persisted responder for the agent. Only provided fields are changed.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.UpdateUserAsync(new UserUpdateRequest { UserId = "user_id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UserUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Benchmarks
<details><summary><code>client.Benchmarks.<a href="/src/Apologist/Benchmarks/BenchmarksClient.cs">ListBenchmarkRunsAsync</a>(ListBenchmarkRunsRequest { ... }) -> WithRawResponseTask&lt;ListBenchmarkRunsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of runs for a benchmark, scoped to the requesting agent. Each run carries nested evaluators, questions, and a flat evaluations array.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Benchmarks.ListBenchmarkRunsAsync(new ListBenchmarkRunsRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListBenchmarkRunsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Benchmarks.<a href="/src/Apologist/Benchmarks/BenchmarksClient.cs">RunBenchmarkAsync</a>(BenchmarkRunRequest { ... }) -> WithRawResponseTask&lt;Dictionary&lt;string, object?&gt;&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Executes a benchmark run and returns the aggregated result with nested evaluators, questions, and a flat evaluations array.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Benchmarks.RunBenchmarkAsync(new BenchmarkRunRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `BenchmarkRunRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Benchmarks.<a href="/src/Apologist/Benchmarks/BenchmarksClient.cs">GetBenchmarkRunAsync</a>(GetBenchmarkRunRequest { ... }) -> WithRawResponseTask&lt;GetBenchmarkRunResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single benchmark run by id or UUID, scoped to the requesting agent, including nested evaluators, questions, and evaluations.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Benchmarks.GetBenchmarkRunAsync(
    new GetBenchmarkRunRequest { Id = "id", RunId = "runId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetBenchmarkRunRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Agent
<details><summary><code>client.Agent.<a href="/src/Apologist/Agent/AgentClient_.cs">PauseAgentAsync</a>() -> WithRawResponseTask&lt;PauseAgentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pauses the agent globally and fans out pause transition messages to open conversations. Requires an API key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agent.PauseAgentAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Agent.<a href="/src/Apologist/Agent/AgentClient_.cs">ResumeAgentAsync</a>() -> WithRawResponseTask&lt;ResumeAgentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Resumes the agent globally and fans out resume transition messages to open conversations. Requires an API key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Agent.ResumeAgentAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Conversations
<details><summary><code>client.Conversations.<a href="/src/Apologist/Conversations/ConversationsClient.cs">ListConversationsAsync</a>(ListConversationsRequest { ... }) -> WithRawResponseTask&lt;ListConversationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of conversations for the requesting agent, newest first.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.ListConversationsAsync(new ListConversationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListConversationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Apologist/Conversations/ConversationsClient.cs">GetConversationAsync</a>(GetConversationRequest { ... }) -> WithRawResponseTask&lt;GetConversationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single conversation by internal UUID or team-scoped external id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.GetConversationAsync(new GetConversationRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetConversationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Apologist/Conversations/ConversationsClient.cs">PauseConversationAsync</a>(PauseConversationRequest { ... }) -> WithRawResponseTask&lt;PauseConversationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pauses the agent on a conversation identified by internal UUID or team-scoped external id. Requires an API key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.PauseConversationAsync(new PauseConversationRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PauseConversationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Conversations.<a href="/src/Apologist/Conversations/ConversationsClient.cs">ResumeConversationAsync</a>(ResumeConversationRequest { ... }) -> WithRawResponseTask&lt;ResumeConversationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Resumes the agent on a conversation identified by internal UUID or team-scoped external id. Requires an API key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Conversations.ResumeConversationAsync(new ResumeConversationRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ResumeConversationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Channels
<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">GetDiscordChannelStatusAsync</a>(GetDiscordChannelStatusRequest { ... }) -> WithRawResponseTask&lt;GetDiscordChannelStatusResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the status of the Discord channel. Used as a lightweight health/verification endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.GetDiscordChannelStatusAsync(
    new GetDiscordChannelStatusRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetDiscordChannelStatusRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveDiscordInteractionAsync</a>(ReceiveDiscordInteractionRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives Discord interaction callbacks for the channel. Requests are verified via Ed25519 signature headers; unsigned or invalid requests are rejected. Payload shape is defined by Discord.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveDiscordInteractionAsync(
    new ReceiveDiscordInteractionRequest
    {
        Id = "id",
        SignatureEd25519 = "x-signature-ed25519",
        SignatureTimestamp = "x-signature-timestamp",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveDiscordInteractionRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">GetLineChannelStatusAsync</a>(GetLineChannelStatusRequest { ... }) -> WithRawResponseTask&lt;GetLineChannelStatusResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the status of the LINE channel. Used as a lightweight health/verification endpoint.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.GetLineChannelStatusAsync(new GetLineChannelStatusRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetLineChannelStatusRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveLineWebhookAsync</a>(ReceiveLineWebhookRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives LINE Messaging API webhook events for the channel. Requests are verified via the `x-line-signature` HMAC-SHA256 (Base64) header using the channel secret unless an `api_key` is present. Payload shape is defined by LINE. The route acknowledges quickly and processes text `message` and `follow` events asynchronously.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveLineWebhookAsync(
    new ReceiveLineWebhookRequest
    {
        Id = "id",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveLineWebhookRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">VerifyFacebookWebhookAsync</a>(VerifyFacebookWebhookRequest { ... }) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Handles the Meta webhook verification handshake, echoing `hub.challenge` when `hub.verify_token` matches the channel's configured token.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.VerifyFacebookWebhookAsync(
    new VerifyFacebookWebhookRequest
    {
        Id = "id",
        HubMode = VerifyFacebookWebhookRequestHubMode.Subscribe,
        HubVerifyToken = "hub.verify_token",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VerifyFacebookWebhookRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveFacebookMessageAsync</a>(ReceiveFacebookMessageRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives Facebook/Messenger (and Instagram-style) message events for the channel. Payload shape is defined by Meta.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveFacebookMessageAsync(
    new ReceiveFacebookMessageRequest
    {
        Id = "id",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveFacebookMessageRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">GetInstagramPrivacyPolicyAsync</a>(GetInstagramPrivacyPolicyRequest { ... }) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a static HTML privacy policy page for the Instagram integration.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.GetInstagramPrivacyPolicyAsync(
    new GetInstagramPrivacyPolicyRequest { Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetInstagramPrivacyPolicyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveTelegramUpdateAsync</a>(ReceiveTelegramUpdateRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives Telegram bot update events for the channel. Non-message updates are acknowledged and ignored. Payload shape is defined by Telegram.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveTelegramUpdateAsync(
    new ReceiveTelegramUpdateRequest
    {
        Id = "id",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveTelegramUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveTwilioMessageAsync</a>(ReceiveTwilioMessageRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives inbound Twilio messages for the channel as form-encoded data. Payload fields are defined by Twilio.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveTwilioMessageAsync(new ReceiveTwilioMessageRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveTwilioMessageRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">VerifyWhatsAppWebhookAsync</a>(VerifyWhatsAppWebhookRequest { ... }) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Handles the Meta WhatsApp Cloud API webhook verification handshake, echoing `hub.challenge` when `hub.verify_token` matches the channel's configured token.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.VerifyWhatsAppWebhookAsync(
    new VerifyWhatsAppWebhookRequest
    {
        Id = "id",
        HubMode = VerifyWhatsAppWebhookRequestHubMode.Subscribe,
        HubVerifyToken = "hub.verify_token",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VerifyWhatsAppWebhookRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Channels.<a href="/src/Apologist/Channels/ChannelsClient.cs">ReceiveWhatsAppMessageAsync</a>(ReceiveWhatsAppMessageRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Receives WhatsApp Cloud API message events for the channel. Payload shape is defined by Meta. Signature verification via `x-hub-signature-256` is used when the channel has an App Secret configured; otherwise the webhook relies on URL secrecy and/or an `api_key` query parameter.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Channels.ReceiveWhatsAppMessageAsync(
    new ReceiveWhatsAppMessageRequest
    {
        Id = "id",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReceiveWhatsAppMessageRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Shares
<details><summary><code>client.Shares.<a href="/src/Apologist/Shares/SharesClient.cs">GetSharedMessagesAsync</a>(GetSharedMessagesRequest { ... }) -> WithRawResponseTask&lt;GetSharedMessagesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Public, unauthenticated read of the messages behind a share token. The token is the bearer capability and enforces tenant isolation against the host agent. An empty or invalid token yields an empty messages array.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.GetSharedMessagesAsync(new GetSharedMessagesRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSharedMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>


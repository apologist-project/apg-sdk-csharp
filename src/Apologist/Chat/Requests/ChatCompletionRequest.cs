using Apologist.Core;
using global::System.Text.Json.Serialization;
using OneOf;

namespace Apologist;

[Serializable]
public record ChatCompletionRequest
{
    /// <summary>
    /// W3C Trace Context parent. When present, the Agent continues this trace for the request. Applies to all `/api/v1` endpoints.
    /// </summary>
    [JsonIgnore]
    public string? Traceparent { get; set; }

    /// <summary>
    /// Optional W3C tracestate associated with traceparent.
    /// </summary>
    [JsonIgnore]
    public string? Tracestate { get; set; }

    /// <summary>
    /// Optional W3C baggage. Prompt text is never copied onto spans.
    /// </summary>
    [JsonIgnore]
    public string? Baggage { get; set; }

    [JsonPropertyName("audio")]
    public Dictionary<string, object?>? Audio { get; set; }

    [JsonPropertyName("frequency_penalty")]
    public double? FrequencyPenalty { get; set; }

    [JsonPropertyName("logit_bias")]
    public Dictionary<string, object?>? LogitBias { get; set; }

    [JsonPropertyName("logprobs")]
    public OneOf<bool, int>? Logprobs { get; set; }

    [JsonPropertyName("top_logprobs")]
    public int? TopLogprobs { get; set; }

    /// <summary>
    /// Output-token cap for this request. An API key may set this above the agent's Max Output Tokens. The value cannot exceed the model's maximum. Requests without an API key keep the agent's Max Output Tokens.
    /// </summary>
    [JsonPropertyName("max_completion_tokens")]
    public int? MaxCompletionTokens { get; set; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; set; }

    /// <summary>
    /// Chat messages in OpenAI format. Required when `prompt` is omitted.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<ChatMessage>? Messages { get; set; }

    [JsonPropertyName("metadata")]
    public ChatCompletionRequestMetadata? Metadata { get; set; }

    [JsonPropertyName("modalities")]
    public IEnumerable<object>? Modalities { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("n")]
    public int? N { get; set; }

    [JsonPropertyName("parallel_tool_calls")]
    public bool? ParallelToolCalls { get; set; }

    [JsonPropertyName("prediction")]
    public Dictionary<string, object?>? Prediction { get; set; }

    [JsonPropertyName("presence_penalty")]
    public double? PresencePenalty { get; set; }

    /// <summary>
    /// User text to complete. Required when `messages` is omitted.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }

    [JsonPropertyName("reasoning_effort")]
    public ChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

    [JsonPropertyName("verbosity")]
    public ChatCompletionRequestVerbosity? Verbosity { get; set; }

    [JsonPropertyName("response_format")]
    public ChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

    [JsonPropertyName("seed")]
    public int? Seed { get; set; }

    [JsonPropertyName("service_tier")]
    public string? ServiceTier { get; set; }

    [JsonPropertyName("stop")]
    public string? Stop { get; set; }

    [JsonPropertyName("store")]
    public bool? Store { get; set; }

    [JsonPropertyName("stream")]
    public bool? Stream { get; set; }

    [JsonPropertyName("stream_options")]
    public Dictionary<string, object?>? StreamOptions { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("top_p")]
    public double? TopP { get; set; }

    /// <summary>
    /// OpenAI-compatible function tool definitions. Passed through to the model as declaration-only tools (the client executes them and returns role=tool messages).
    /// </summary>
    [JsonPropertyName("tools")]
    public IEnumerable<object>? Tools { get; set; }

    [JsonPropertyName("tool_choice")]
    public OneOf<
        ChatCompletionRequestToolChoiceZero,
        Dictionary<string, object?>?
    >? ToolChoice { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}

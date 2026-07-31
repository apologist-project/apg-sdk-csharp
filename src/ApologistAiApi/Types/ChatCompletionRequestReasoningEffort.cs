using ApologistAiApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[JsonConverter(
    typeof(ChatCompletionRequestReasoningEffort.ChatCompletionRequestReasoningEffortSerializer)
)]
[Serializable]
public readonly record struct ChatCompletionRequestReasoningEffort : IStringEnum
{
    public static readonly ChatCompletionRequestReasoningEffort Low = new(Values.Low);

    public static readonly ChatCompletionRequestReasoningEffort Medium = new(Values.Medium);

    public static readonly ChatCompletionRequestReasoningEffort High = new(Values.High);

    public ChatCompletionRequestReasoningEffort(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ChatCompletionRequestReasoningEffort FromCustom(string value)
    {
        return new ChatCompletionRequestReasoningEffort(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ChatCompletionRequestReasoningEffort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChatCompletionRequestReasoningEffort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChatCompletionRequestReasoningEffort value) =>
        value.Value;

    public static explicit operator ChatCompletionRequestReasoningEffort(string value) =>
        new(value);

    internal class ChatCompletionRequestReasoningEffortSerializer
        : JsonConverter<ChatCompletionRequestReasoningEffort>
    {
        public override ChatCompletionRequestReasoningEffort Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new ChatCompletionRequestReasoningEffort(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChatCompletionRequestReasoningEffort value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChatCompletionRequestReasoningEffort ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new ChatCompletionRequestReasoningEffort(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChatCompletionRequestReasoningEffort value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Low = "low";

        public const string Medium = "medium";

        public const string High = "high";
    }
}

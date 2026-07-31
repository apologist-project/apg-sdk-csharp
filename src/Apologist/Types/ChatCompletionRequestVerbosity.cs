using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(typeof(ChatCompletionRequestVerbosity.ChatCompletionRequestVerbositySerializer))]
[Serializable]
public readonly record struct ChatCompletionRequestVerbosity : IStringEnum
{
    public static readonly ChatCompletionRequestVerbosity Minimal = new(Values.Minimal);

    public static readonly ChatCompletionRequestVerbosity Low = new(Values.Low);

    public static readonly ChatCompletionRequestVerbosity Medium = new(Values.Medium);

    public static readonly ChatCompletionRequestVerbosity High = new(Values.High);

    public ChatCompletionRequestVerbosity(string value)
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
    public static ChatCompletionRequestVerbosity FromCustom(string value)
    {
        return new ChatCompletionRequestVerbosity(value);
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

    public static bool operator ==(ChatCompletionRequestVerbosity value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChatCompletionRequestVerbosity value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChatCompletionRequestVerbosity value) => value.Value;

    public static explicit operator ChatCompletionRequestVerbosity(string value) => new(value);

    internal class ChatCompletionRequestVerbositySerializer
        : JsonConverter<ChatCompletionRequestVerbosity>
    {
        public override ChatCompletionRequestVerbosity Read(
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
            return new ChatCompletionRequestVerbosity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChatCompletionRequestVerbosity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChatCompletionRequestVerbosity ReadAsPropertyName(
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
            return new ChatCompletionRequestVerbosity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChatCompletionRequestVerbosity value,
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
        public const string Minimal = "minimal";

        public const string Low = "low";

        public const string Medium = "medium";

        public const string High = "high";
    }
}

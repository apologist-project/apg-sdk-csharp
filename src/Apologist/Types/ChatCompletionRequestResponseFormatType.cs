using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(
    typeof(ChatCompletionRequestResponseFormatType.ChatCompletionRequestResponseFormatTypeSerializer)
)]
[Serializable]
public readonly record struct ChatCompletionRequestResponseFormatType : IStringEnum
{
    public static readonly ChatCompletionRequestResponseFormatType Text = new(Values.Text);

    public static readonly ChatCompletionRequestResponseFormatType Html = new(Values.Html);

    public static readonly ChatCompletionRequestResponseFormatType Json = new(Values.Json);

    public static readonly ChatCompletionRequestResponseFormatType Raw = new(Values.Raw);

    public static readonly ChatCompletionRequestResponseFormatType JsonSchema = new(
        Values.JsonSchema
    );

    public ChatCompletionRequestResponseFormatType(string value)
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
    public static ChatCompletionRequestResponseFormatType FromCustom(string value)
    {
        return new ChatCompletionRequestResponseFormatType(value);
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

    public static bool operator ==(ChatCompletionRequestResponseFormatType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChatCompletionRequestResponseFormatType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChatCompletionRequestResponseFormatType value) =>
        value.Value;

    public static explicit operator ChatCompletionRequestResponseFormatType(string value) =>
        new(value);

    internal class ChatCompletionRequestResponseFormatTypeSerializer
        : JsonConverter<ChatCompletionRequestResponseFormatType>
    {
        public override ChatCompletionRequestResponseFormatType Read(
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
            return new ChatCompletionRequestResponseFormatType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChatCompletionRequestResponseFormatType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChatCompletionRequestResponseFormatType ReadAsPropertyName(
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
            return new ChatCompletionRequestResponseFormatType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChatCompletionRequestResponseFormatType value,
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
        public const string Text = "text";

        public const string Html = "html";

        public const string Json = "json";

        public const string Raw = "raw";

        public const string JsonSchema = "json_schema";
    }
}

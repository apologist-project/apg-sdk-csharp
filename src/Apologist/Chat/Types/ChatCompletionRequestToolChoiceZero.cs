using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(
    typeof(ChatCompletionRequestToolChoiceZero.ChatCompletionRequestToolChoiceZeroSerializer)
)]
[Serializable]
public readonly record struct ChatCompletionRequestToolChoiceZero : IStringEnum
{
    public static readonly ChatCompletionRequestToolChoiceZero None = new(Values.None);

    public static readonly ChatCompletionRequestToolChoiceZero Auto = new(Values.Auto);

    public static readonly ChatCompletionRequestToolChoiceZero Required = new(Values.Required);

    public ChatCompletionRequestToolChoiceZero(string value)
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
    public static ChatCompletionRequestToolChoiceZero FromCustom(string value)
    {
        return new ChatCompletionRequestToolChoiceZero(value);
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

    public static bool operator ==(ChatCompletionRequestToolChoiceZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChatCompletionRequestToolChoiceZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChatCompletionRequestToolChoiceZero value) =>
        value.Value;

    public static explicit operator ChatCompletionRequestToolChoiceZero(string value) => new(value);

    internal class ChatCompletionRequestToolChoiceZeroSerializer
        : JsonConverter<ChatCompletionRequestToolChoiceZero>
    {
        public override ChatCompletionRequestToolChoiceZero Read(
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
            return new ChatCompletionRequestToolChoiceZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChatCompletionRequestToolChoiceZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChatCompletionRequestToolChoiceZero ReadAsPropertyName(
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
            return new ChatCompletionRequestToolChoiceZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChatCompletionRequestToolChoiceZero value,
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
        public const string None = "none";

        public const string Auto = "auto";

        public const string Required = "required";
    }
}

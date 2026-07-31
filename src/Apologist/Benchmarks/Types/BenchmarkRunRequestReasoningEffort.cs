using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(
    typeof(BenchmarkRunRequestReasoningEffort.BenchmarkRunRequestReasoningEffortSerializer)
)]
[Serializable]
public readonly record struct BenchmarkRunRequestReasoningEffort : IStringEnum
{
    public static readonly BenchmarkRunRequestReasoningEffort Low = new(Values.Low);

    public static readonly BenchmarkRunRequestReasoningEffort Medium = new(Values.Medium);

    public static readonly BenchmarkRunRequestReasoningEffort High = new(Values.High);

    public BenchmarkRunRequestReasoningEffort(string value)
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
    public static BenchmarkRunRequestReasoningEffort FromCustom(string value)
    {
        return new BenchmarkRunRequestReasoningEffort(value);
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

    public static bool operator ==(BenchmarkRunRequestReasoningEffort value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BenchmarkRunRequestReasoningEffort value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BenchmarkRunRequestReasoningEffort value) => value.Value;

    public static explicit operator BenchmarkRunRequestReasoningEffort(string value) => new(value);

    internal class BenchmarkRunRequestReasoningEffortSerializer
        : JsonConverter<BenchmarkRunRequestReasoningEffort>
    {
        public override BenchmarkRunRequestReasoningEffort Read(
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
            return new BenchmarkRunRequestReasoningEffort(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BenchmarkRunRequestReasoningEffort value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BenchmarkRunRequestReasoningEffort ReadAsPropertyName(
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
            return new BenchmarkRunRequestReasoningEffort(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BenchmarkRunRequestReasoningEffort value,
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

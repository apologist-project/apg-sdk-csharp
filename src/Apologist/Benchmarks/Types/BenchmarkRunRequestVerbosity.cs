using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(typeof(BenchmarkRunRequestVerbosity.BenchmarkRunRequestVerbositySerializer))]
[Serializable]
public readonly record struct BenchmarkRunRequestVerbosity : IStringEnum
{
    public static readonly BenchmarkRunRequestVerbosity Minimal = new(Values.Minimal);

    public static readonly BenchmarkRunRequestVerbosity Low = new(Values.Low);

    public static readonly BenchmarkRunRequestVerbosity Medium = new(Values.Medium);

    public static readonly BenchmarkRunRequestVerbosity High = new(Values.High);

    public BenchmarkRunRequestVerbosity(string value)
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
    public static BenchmarkRunRequestVerbosity FromCustom(string value)
    {
        return new BenchmarkRunRequestVerbosity(value);
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

    public static bool operator ==(BenchmarkRunRequestVerbosity value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BenchmarkRunRequestVerbosity value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BenchmarkRunRequestVerbosity value) => value.Value;

    public static explicit operator BenchmarkRunRequestVerbosity(string value) => new(value);

    internal class BenchmarkRunRequestVerbositySerializer
        : JsonConverter<BenchmarkRunRequestVerbosity>
    {
        public override BenchmarkRunRequestVerbosity Read(
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
            return new BenchmarkRunRequestVerbosity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BenchmarkRunRequestVerbosity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BenchmarkRunRequestVerbosity ReadAsPropertyName(
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
            return new BenchmarkRunRequestVerbosity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BenchmarkRunRequestVerbosity value,
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

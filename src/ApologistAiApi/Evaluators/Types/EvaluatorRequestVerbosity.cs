using ApologistAiApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[JsonConverter(typeof(EvaluatorRequestVerbosity.EvaluatorRequestVerbositySerializer))]
[Serializable]
public readonly record struct EvaluatorRequestVerbosity : IStringEnum
{
    public static readonly EvaluatorRequestVerbosity Minimal = new(Values.Minimal);

    public static readonly EvaluatorRequestVerbosity Low = new(Values.Low);

    public static readonly EvaluatorRequestVerbosity Medium = new(Values.Medium);

    public static readonly EvaluatorRequestVerbosity High = new(Values.High);

    public EvaluatorRequestVerbosity(string value)
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
    public static EvaluatorRequestVerbosity FromCustom(string value)
    {
        return new EvaluatorRequestVerbosity(value);
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

    public static bool operator ==(EvaluatorRequestVerbosity value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EvaluatorRequestVerbosity value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EvaluatorRequestVerbosity value) => value.Value;

    public static explicit operator EvaluatorRequestVerbosity(string value) => new(value);

    internal class EvaluatorRequestVerbositySerializer : JsonConverter<EvaluatorRequestVerbosity>
    {
        public override EvaluatorRequestVerbosity Read(
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
            return new EvaluatorRequestVerbosity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EvaluatorRequestVerbosity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EvaluatorRequestVerbosity ReadAsPropertyName(
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
            return new EvaluatorRequestVerbosity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EvaluatorRequestVerbosity value,
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

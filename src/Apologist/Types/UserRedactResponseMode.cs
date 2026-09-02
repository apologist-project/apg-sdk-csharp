using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(typeof(UserRedactResponseMode.UserRedactResponseModeSerializer))]
[Serializable]
public readonly record struct UserRedactResponseMode : IStringEnum
{
    public static readonly UserRedactResponseMode Scrub = new(Values.Scrub);

    public static readonly UserRedactResponseMode Anonymize = new(Values.Anonymize);

    public UserRedactResponseMode(string value)
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
    public static UserRedactResponseMode FromCustom(string value)
    {
        return new UserRedactResponseMode(value);
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

    public static bool operator ==(UserRedactResponseMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UserRedactResponseMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UserRedactResponseMode value) => value.Value;

    public static explicit operator UserRedactResponseMode(string value) => new(value);

    internal class UserRedactResponseModeSerializer : JsonConverter<UserRedactResponseMode>
    {
        public override UserRedactResponseMode Read(
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
            return new UserRedactResponseMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UserRedactResponseMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UserRedactResponseMode ReadAsPropertyName(
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
            return new UserRedactResponseMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UserRedactResponseMode value,
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
        public const string Scrub = "scrub";

        public const string Anonymize = "anonymize";
    }
}

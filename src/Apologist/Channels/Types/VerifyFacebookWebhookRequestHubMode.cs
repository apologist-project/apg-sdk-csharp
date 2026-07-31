using Apologist.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Apologist;

[JsonConverter(
    typeof(VerifyFacebookWebhookRequestHubMode.VerifyFacebookWebhookRequestHubModeSerializer)
)]
[Serializable]
public readonly record struct VerifyFacebookWebhookRequestHubMode : IStringEnum
{
    public static readonly VerifyFacebookWebhookRequestHubMode Subscribe = new(Values.Subscribe);

    public VerifyFacebookWebhookRequestHubMode(string value)
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
    public static VerifyFacebookWebhookRequestHubMode FromCustom(string value)
    {
        return new VerifyFacebookWebhookRequestHubMode(value);
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

    public static bool operator ==(VerifyFacebookWebhookRequestHubMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VerifyFacebookWebhookRequestHubMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VerifyFacebookWebhookRequestHubMode value) =>
        value.Value;

    public static explicit operator VerifyFacebookWebhookRequestHubMode(string value) => new(value);

    internal class VerifyFacebookWebhookRequestHubModeSerializer
        : JsonConverter<VerifyFacebookWebhookRequestHubMode>
    {
        public override VerifyFacebookWebhookRequestHubMode Read(
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
            return new VerifyFacebookWebhookRequestHubMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VerifyFacebookWebhookRequestHubMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VerifyFacebookWebhookRequestHubMode ReadAsPropertyName(
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
            return new VerifyFacebookWebhookRequestHubMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VerifyFacebookWebhookRequestHubMode value,
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
        public const string Subscribe = "subscribe";
    }
}

using ApologistAiApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApologistAiApi;

[JsonConverter(typeof(WebhookEventInfoKey.WebhookEventInfoKeySerializer))]
[Serializable]
public readonly record struct WebhookEventInfoKey : IStringEnum
{
    public static readonly WebhookEventInfoKey PromptSubmit = new(Values.PromptSubmit);

    public static readonly WebhookEventInfoKey ResponseStart = new(Values.ResponseStart);

    public static readonly WebhookEventInfoKey ResponseEnd = new(Values.ResponseEnd);

    public static readonly WebhookEventInfoKey AutomationsEnd = new(Values.AutomationsEnd);

    public static readonly WebhookEventInfoKey ResponseLike = new(Values.ResponseLike);

    public static readonly WebhookEventInfoKey ResponseFlag = new(Values.ResponseFlag);

    public static readonly WebhookEventInfoKey ResponseFeedback = new(Values.ResponseFeedback);

    public static readonly WebhookEventInfoKey ReferralClick = new(Values.ReferralClick);

    public static readonly WebhookEventInfoKey CtaTrigger = new(Values.CtaTrigger);

    public static readonly WebhookEventInfoKey CtaClick = new(Values.CtaClick);

    public static readonly WebhookEventInfoKey GuardrailTrigger = new(Values.GuardrailTrigger);

    public static readonly WebhookEventInfoKey AttributionClick = new(Values.AttributionClick);

    public static readonly WebhookEventInfoKey FooterClick = new(Values.FooterClick);

    public static readonly WebhookEventInfoKey NewUser = new(Values.NewUser);

    public static readonly WebhookEventInfoKey NewDevice = new(Values.NewDevice);

    public static readonly WebhookEventInfoKey NewSession = new(Values.NewSession);

    public static readonly WebhookEventInfoKey NewConversation = new(Values.NewConversation);

    public static readonly WebhookEventInfoKey Error = new(Values.Error);

    public WebhookEventInfoKey(string value)
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
    public static WebhookEventInfoKey FromCustom(string value)
    {
        return new WebhookEventInfoKey(value);
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

    public static bool operator ==(WebhookEventInfoKey value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhookEventInfoKey value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhookEventInfoKey value) => value.Value;

    public static explicit operator WebhookEventInfoKey(string value) => new(value);

    internal class WebhookEventInfoKeySerializer : JsonConverter<WebhookEventInfoKey>
    {
        public override WebhookEventInfoKey Read(
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
            return new WebhookEventInfoKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WebhookEventInfoKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WebhookEventInfoKey ReadAsPropertyName(
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
            return new WebhookEventInfoKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WebhookEventInfoKey value,
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
        public const string PromptSubmit = "prompt_submit";

        public const string ResponseStart = "response_start";

        public const string ResponseEnd = "response_end";

        public const string AutomationsEnd = "automations_end";

        public const string ResponseLike = "response_like";

        public const string ResponseFlag = "response_flag";

        public const string ResponseFeedback = "response_feedback";

        public const string ReferralClick = "referral_click";

        public const string CtaTrigger = "cta_trigger";

        public const string CtaClick = "cta_click";

        public const string GuardrailTrigger = "guardrail_trigger";

        public const string AttributionClick = "attribution_click";

        public const string FooterClick = "footer_click";

        public const string NewUser = "new_user";

        public const string NewDevice = "new_device";

        public const string NewSession = "new_session";

        public const string NewConversation = "new_conversation";

        public const string Error = "error";
    }
}

namespace Apologist;

public partial interface IChannelsClient
{
    /// <summary>
    /// Returns the status of the Discord channel. Used as a lightweight health/verification endpoint.
    /// </summary>
    WithRawResponseTask<GetDiscordChannelStatusResponse> GetDiscordChannelStatusAsync(
        GetDiscordChannelStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Receives Discord interaction callbacks for the channel. Requests are verified via Ed25519 signature headers; unsigned or invalid requests are rejected. Payload shape is defined by Discord.
    /// </summary>
    WithRawResponseTask ReceiveDiscordInteractionAsync(
        ReceiveDiscordInteractionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Handles the Meta webhook verification handshake, echoing `hub.challenge` when `hub.verify_token` matches the channel's configured token.
    /// </summary>
    WithRawResponseTask<string> VerifyFacebookWebhookAsync(
        VerifyFacebookWebhookRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Receives Facebook/Messenger (and Instagram-style) message events for the channel. Payload shape is defined by Meta.
    /// </summary>
    WithRawResponseTask ReceiveFacebookMessageAsync(
        ReceiveFacebookMessageRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a static HTML privacy policy page for the Instagram integration.
    /// </summary>
    WithRawResponseTask<string> GetInstagramPrivacyPolicyAsync(
        GetInstagramPrivacyPolicyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Receives Telegram bot update events for the channel. Non-message updates are acknowledged and ignored. Payload shape is defined by Telegram.
    /// </summary>
    WithRawResponseTask ReceiveTelegramUpdateAsync(
        ReceiveTelegramUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Receives inbound Twilio messages for the channel as form-encoded data. Payload fields are defined by Twilio.
    /// </summary>
    WithRawResponseTask ReceiveTwilioMessageAsync(
        ReceiveTwilioMessageRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}

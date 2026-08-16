using Apologist.Core;

namespace Apologist;

public partial class AgentClient : IAgentClient
{
    private readonly RawClient _client;

    public AgentClient(string apiKey, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        if (clientOptions.Domain != null)
        {
            var _domain = clientOptions.Domain ?? "your-agent-domain.com";
            if (!clientOptions.IsBaseUrlExplicitlySet)
            {
                clientOptions.BaseUrl = $"https://{_domain}/api/v1";
            }
            else if (clientOptions.BaseUrl == AgentClientEnvironment.Default)
            {
                clientOptions.BaseUrl = $"https://{_domain}/api/v1";
            }
        }
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "apologist" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "apologist/1.0.5" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(new Dictionary<string, string>() { { "x-api-key", apiKey } });
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Chat = new ChatClient(_client);
        Corpus = new CorpusClient(_client);
        Evaluators = new EvaluatorsClient(_client);
        CtAs = new CtAsClient(_client);
        Users = new UsersClient(_client);
        Benchmarks = new BenchmarksClient(_client);
        Channels = new ChannelsClient(_client);
        Shares = new SharesClient(_client);
    }

    public IChatClient Chat { get; }

    public ICorpusClient Corpus { get; }

    public IEvaluatorsClient Evaluators { get; }

    public ICtAsClient CtAs { get; }

    public IUsersClient Users { get; }

    public IBenchmarksClient Benchmarks { get; }

    public IChannelsClient Channels { get; }

    public ISharesClient Shares { get; }
}

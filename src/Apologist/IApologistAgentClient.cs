namespace Apologist;

public partial interface IApologistAgentClient
{
    public IChatClient Chat { get; }
    public ICorpusClient Corpus { get; }
    public IEvaluatorsClient Evaluators { get; }
    public ICtAsClient CtAs { get; }
    public IUsersClient Users { get; }
    public IBenchmarksClient Benchmarks { get; }
    public IChannelsClient Channels { get; }
    public ISharesClient Shares { get; }
}

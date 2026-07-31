namespace Apologist.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}

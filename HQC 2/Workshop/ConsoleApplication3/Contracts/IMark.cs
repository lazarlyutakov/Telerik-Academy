using SchoolSystem.Enums;

namespace SchoolSystem.Contracts
{
    public interface IMark
    {
        Subject Subject { get; }

        float MarkValue { get; }
    }
}

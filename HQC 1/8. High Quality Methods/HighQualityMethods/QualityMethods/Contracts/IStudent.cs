namespace QualityMethods.Contracts
{
    public interface IStudent
    {
        string FirstName { get; }

        string LastName { get; }

        OtherInformation OtherInfo { get; }
    }
}

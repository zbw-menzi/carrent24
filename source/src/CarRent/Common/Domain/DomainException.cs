namespace CarRent.Common.Domain
{
    public class DomainException : Exception
    {
        public DomainException(string code, string message)
            : base(message)
        {
        }
    }
}

namespace CarRent.Common.Domain
{
    public interface IUnitOfWork
    {
        int CommitChanges();
    }
}

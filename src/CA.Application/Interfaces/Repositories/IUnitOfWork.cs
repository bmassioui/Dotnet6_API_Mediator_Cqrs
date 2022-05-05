namespace CA.Application.Interfaces.Repositories;

public interface IUnitOfWork
{
    IOwnerRepository Owner { get; }
    IAccountRepository Account { get; }

    /// <summary>
    /// Create Transaction
    /// </summary>
    void CreateTransaction();

    /// <summary>
    /// Commit the Transaction
    /// </summary>
    void Commit();

    /// <summary>
    /// Rollback the Transaction
    /// </summary>
    void Rollback();

    /// <summary>
    /// Save changes - Async
    /// </summary>
    Task SaveChangesAsync();
}
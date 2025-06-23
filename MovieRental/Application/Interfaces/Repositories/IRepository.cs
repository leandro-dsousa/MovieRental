namespace MovieRental.Application.Interfaces.Repositories;

public interface IRepository
{
    Task BeginTransaction();
    Task CommitTransaction();
    Task RollbackTransaction();
}
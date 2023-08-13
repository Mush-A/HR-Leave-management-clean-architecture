namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}


// where T : class
// This is a constraint applied to the generic type parameter 'T'.
// It ensures that the type 'T' must be a reference type
// (a class or interface) and cannot be a value type
// (e.g., int, double, struct).
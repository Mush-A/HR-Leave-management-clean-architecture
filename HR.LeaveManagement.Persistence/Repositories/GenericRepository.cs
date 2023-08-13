using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HrDatabaseContext _hrDatabaseContext;

        public GenericRepository(HrDatabaseContext hrDatabaseContext)
        {
            _hrDatabaseContext = hrDatabaseContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _hrDatabaseContext.AddAsync(entity);
            await _hrDatabaseContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _hrDatabaseContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _hrDatabaseContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            // _hrDatabaseContext.Update(entity);
            _hrDatabaseContext.Entry(entity).State = EntityState.Modified;
            await _hrDatabaseContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _hrDatabaseContext.Remove(entity);
            await _hrDatabaseContext.SaveChangesAsync();
        }
    }
}

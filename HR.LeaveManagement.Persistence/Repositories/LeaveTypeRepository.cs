using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository // Inherit from the implementation GenericRepository and the IleaveTypeRepository
{
    public LeaveTypeRepository(HrDatabaseContext hrDatabaseContext) : base(hrDatabaseContext)
    {
    }

    public async Task<bool> IsLeaveTypeUnique(string name)
    {
        return await _hrDatabaseContext.LeaveTypes.AnyAsync(p => p.Name == name);
    }
}

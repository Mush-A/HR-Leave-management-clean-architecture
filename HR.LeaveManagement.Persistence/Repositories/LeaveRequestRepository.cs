using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;

namespace HR.LeaveManagement.Persistence.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRespository
{
    public LeaveRequestRepository(HrDatabaseContext hrDatabaseContext) : base(hrDatabaseContext)
    {
    }
}

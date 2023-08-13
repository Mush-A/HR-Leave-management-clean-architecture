using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<bool> IsLeaveTypeUnique(string name);
}


// where T : class
// This is a constraint applied to the generic type parameter 'T'.
// It ensures that the type 'T' must be a reference type
// (a class or interface) and cannot be a value type
// (e.g., int, double, struct).
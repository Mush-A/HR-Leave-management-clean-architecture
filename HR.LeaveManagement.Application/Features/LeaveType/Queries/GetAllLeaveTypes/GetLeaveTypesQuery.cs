
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

//    public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
//    {
//    }

public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;

// A record is immutable and once you define nothing
// will change
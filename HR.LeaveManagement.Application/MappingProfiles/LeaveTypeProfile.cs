using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

namespace HR.LeaveManagement.Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<Domain.LeaveType, LeaveTypeDto>().ReverseMap();
        CreateMap<Domain.LeaveType, LeaveTypeDetailsDto>();
    }
}

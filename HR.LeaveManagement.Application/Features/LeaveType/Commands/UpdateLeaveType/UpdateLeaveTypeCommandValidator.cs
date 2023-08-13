using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType;

public class UpdateLeaveTypeCommandValidator : AbstractValidator<UpdateLeaveTypeCommand>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public UpdateLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;

        RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage(p => $"{p.Name} is required")
            .NotNull()
            .MaximumLength(70)
            .WithMessage(p => $"{p.Name} must not exceed 70 characters");

        RuleFor(p => p.DefaultDays)
            .LessThan(100)
            .WithMessage(p => $"{p.Name} cannot exceed 100")
            .GreaterThan(1)
            .WithMessage(p => $"{p.Name} cannot be less than 1");

        RuleFor(p => p)
            .NotEmpty()
            .MustAsync(LeaveTypeNameUnique)
            .WithMessage("Leave Type Already Exists.");

    }

    private async Task<bool> LeaveTypeNameUnique(UpdateLeaveTypeCommand command, CancellationToken cancellation)
    {
        return await _leaveTypeRepository.IsLeaveTypeUnique(command.Name);
    }
}

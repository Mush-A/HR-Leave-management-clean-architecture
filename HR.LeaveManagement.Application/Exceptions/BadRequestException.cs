
using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {

    }

    public List<string> ValidationErros { get; set; }

    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        ValidationErros = new();
        foreach (var error in validationResult.Errors)
        {
            ValidationErros.Add(error.ErrorMessage);
        }
    }
}

using FluentValidation;

namespace User.Domain.Validators;

public class UserValidator : AbstractValidator<Entities.User>
{
    public UserValidator()
    {
        RuleFor(user => user.Username)
            .NotEmpty().WithMessage("Username is required.")
            .Length(3, 50).WithMessage("Username must be between 3 and 50 characters.");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(user => user.Role)
            .IsInEnum().WithMessage("Invalid user role.");

        RuleFor(user => user.isActive)
            .NotNull().WithMessage("isActive is required.");
        
        RuleFor(user => user.CreatedAt)
            .NotEmpty().WithMessage("CreatedAt is required.");
    }
}
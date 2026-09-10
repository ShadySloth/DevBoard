using FluentValidation;
using User.Domain.Entities;

namespace User.Domain.Validators;

public class UserCredentialValidator : AbstractValidator<UserCredential>
{
    public UserCredentialValidator()
    {
        RuleFor(credential => credential.PasswordHash)
            .NotEmpty().WithMessage("Password hash is required.");
        
        RuleFor(credential => credential.CreatedAt)
            .NotEmpty().WithMessage("CreatedAt is required.");
    }
}
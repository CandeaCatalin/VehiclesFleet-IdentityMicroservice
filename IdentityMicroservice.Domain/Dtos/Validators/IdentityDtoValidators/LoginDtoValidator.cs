using FluentValidation;
using IdentityMicroservice.Domain.Dtos.IdentityControllerDtos;

namespace IdentityMicroservice.Domain.Dtos.Validators.IdentityDtoValidators;

public class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(x => x.Email).NotEmpty().WithMessage("Please provide an email!");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Please provide a password!");
    }
}
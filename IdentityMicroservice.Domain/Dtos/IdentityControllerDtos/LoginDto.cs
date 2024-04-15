using FluentValidation;
using IdentityMicroservice.Domain.Dtos.Validators.IdentityDtoValidators;

namespace IdentityMicroservice.Domain.Dtos.IdentityControllerDtos;

public class LoginDto
{
    public static LoginDtoValidator Validator => new();
    public string? Email { get; set; } = "";
    public string? Password { get; set; } = "";
    public async Task ValidateAndThrow()
    {
        await Validator.ValidateAndThrowAsync(this);
    }
}
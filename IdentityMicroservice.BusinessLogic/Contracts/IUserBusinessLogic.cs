using IdentityMicroservice.Domain.Dtos.IdentityControllerDtos;
using IdentityMicroservice.Domain.Models.Identity;

namespace IdentityMicroservice.BusinessLogic.Contracts;

public interface IUserBusinessLogic
{
    public Task<string> Login(LoginDto loginDto);
    public Task Register(RegisterDto registerDto);
    public Task<List<User>> GetAllUsers();
}
using IdentityMicroservice.Domain.Dtos.IdentityControllerDtos;
using IdentityMicroservice.Domain.Models.Identity;

namespace IdentityMicroservice.Repository.Contracts;

public interface IUserRepository
{
    public Task<string> Login(LoginDto loginDto);
    public Task<string> Register(RegisterDto registerDto);

    public Task<List<User>> GetAllUsers();
}
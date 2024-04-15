using IdentityMicroservice.BusinessLogic.Contracts;
using IdentityMicroservice.Domain.Dtos.IdentityControllerDtos;
using IdentityMicroservice.Domain.Models.Identity;
using IdentityMicroservice.Repository.Contracts;
using IdentityMicroservice.Services.Contracts;
using Microsoft.Extensions.Logging;

namespace IdentityMicroservice.BusinessLogic;

public class UserBusinessLogic : IUserBusinessLogic
{
    private readonly IUserRepository userRepository;
    private readonly ILoggerService loggerService;

    public UserBusinessLogic(IUserRepository userRepository,ILoggerService loggerService)
    {
        this.userRepository = userRepository;
        this.loggerService = loggerService;
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await userRepository.GetAllUsers();
    }

    public async Task<string> Login(LoginDto loginDto)
    {
        await loginDto.ValidateAndThrow();
        var token = await userRepository.Login(loginDto);
        
        await loggerService.LogInfo($"User logged in!",token);
        return token;
    }

    public async Task Register(RegisterDto registerDto)
    {
        await registerDto.ValidateAndThrow();
        var token = await userRepository.Register(registerDto);
        
        await loggerService.LogInfo($"New user was registered successfully!","token");
    }
}
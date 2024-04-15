using IdentityMicroservice.DataAccess;

namespace IdentityMicroservice.Services.Contracts;

public interface IJwtService
{
     string GenerateToken(User existingUser);
     string GetUserEmailFromToken(string token);
}
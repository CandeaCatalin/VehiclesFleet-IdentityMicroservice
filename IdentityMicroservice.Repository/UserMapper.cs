using IdentityMicroservice.Domain.Models.Identity;
using IdentityMicroservice.Repository.Contracts;

namespace IdentityMicroservice.Repository;

public class UserMapper : IUserMapper
{
    public User DataAccessToDomain(IdentityMicroservice.DataAccess.User user)
    {
        return new User
        {
            Email = user.Email,
            Name = user.Name,
            CreatedAtTimeUtc = user.CreatedAtTimeUtc
        };
    }
}
using IdentityMicroservice.Domain.Models.Identity;

namespace IdentityMicroservice.Repository.Contracts;

public interface IUserMapper
{
    public User DataAccessToDomain(IdentityMicroservice.DataAccess.User user);
}
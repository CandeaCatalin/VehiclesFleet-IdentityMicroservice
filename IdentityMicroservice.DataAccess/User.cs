using Microsoft.AspNetCore.Identity;

namespace IdentityMicroservice.DataAccess;

public class User : IdentityUser
{
    public DateTime CreatedAtTimeUtc { get; set; }
    public string? Name { get; set; }
    public Guid? VehicleId { get; set; }
}
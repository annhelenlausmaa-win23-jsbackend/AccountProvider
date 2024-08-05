using Microsoft.AspNetCore.Identity;

namespace Data.Entities;

public class UserAccount : IdentityUser
{
    public string? FirstName { get; set; } = null!;
    public string? LastName { get; set; } = null!;
    public string? Biography { get; set; }
    public string? ProfileImage { get; set; } = "avatar.jpg";
    public string? AddressId { get; set; }
    public UserAddress? Address { get; set; }
}

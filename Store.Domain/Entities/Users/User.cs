using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;
namespace Store.Domain.Entities.Users;

public class User : IdentityUser<int>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsDeleted { get; set; }
    public ICollection<Address>? Addresses { get; set; }

    public User()
    {
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }

}

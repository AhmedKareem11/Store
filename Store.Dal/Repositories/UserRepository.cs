using Microsoft.EntityFrameworkCore;
using Store.Dal.Context;
using Store.Domain.Abstractions.Repositories;
using Store.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {

    }

    public override void Remove(User user)
    {
        user.IsDeleted = true;
    }

    public override void RemoveRange(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            Remove(user);
        }
    }

    public async Task<IEnumerable<User>> GetUsersByRoleAsync(string roleName)
    {
        return await (from user in context.Users
                      join userRole in context.UserRoles on user.Id equals userRole.UserId
                      join role in context.Roles on userRole.RoleId equals role.Id
                      where role.Name == roleName
                      select user).ToListAsync();
    }
}

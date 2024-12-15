using Store.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Abstractions.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<IEnumerable<User>> GetUsersByRoleAsync(string roleName);
}

using CarCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarCity.Services
{
    public interface IRoleRepository
    {
        void Add(Role role);
        Task Save();
        Task<List<Role>> GetAll();
        Task<List<Role>> GetRoles(Expression<Func<Role, bool>> predicate);
    }
}

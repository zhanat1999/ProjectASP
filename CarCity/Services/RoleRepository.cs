using CarCity.Data;
using CarCity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarCity.Services
{
    public class RoleRepository
    {
        readonly DBContext _context;

        public RoleRepository(DBContext context)
        {
            _context = context;
        }
        public void Add(Role role)
        {
            _context.Add(role);
        }

        public Task<List<Role>> GetRoles(Expression<Func<Role, bool>> predicate)
        {
            return _context.Role.Where(predicate).ToListAsync();
        }

        public Task<List<Role>> GetAll()
        {
            return _context.Role.ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}

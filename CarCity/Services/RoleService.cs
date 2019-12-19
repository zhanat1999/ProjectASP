using CarCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepo;

        public RoleService(IRoleRepository roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public async Task<List<Role>> GetRoles()
        {
            return await _roleRepo.GetAll();
        }

        public async Task AddAndSave(Role role)
        {
            _roleRepo.Add(role);
            await _roleRepo.Save();
        }
    }
}

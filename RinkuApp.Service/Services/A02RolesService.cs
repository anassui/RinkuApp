using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.Repositories
{
    public class A02RolesService : IA02RolesService
    {
        private readonly IA02RolesRepository _repository;

        public A02RolesService(IA02RolesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<A02Roles>> GetRoles()
        {
            return await _repository.GetRoles().ConfigureAwait(false);
        }

        public async Task<A02Roles> GetRolesById(long id)
        {
            return await _repository.GetRolesById(id).ConfigureAwait(false);
        }

        public async Task Update(A02Roles A02Roles)
        {
            await _repository.Update(A02Roles).ConfigureAwait(false);
        }

        public async Task Create(A02Roles A02Roles)
        {

            await _repository.Create(A02Roles).ConfigureAwait(false);
        }

        public async Task<A02Roles> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }

    }
}

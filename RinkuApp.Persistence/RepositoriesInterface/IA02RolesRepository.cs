using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IA02RolesRepository
    {
        Task<IEnumerable<A02Roles>> GetRoles();

        Task<A02Roles> GetRolesById(long id);

        Task Update(A02Roles A02Roles);

        Task Create(A02Roles A02Roles);

        Task<A02Roles> Delete(long id);
    }
}

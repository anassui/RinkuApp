using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp. Services.ServicesInterface
{
    public interface IA02RolesService
    {
        Task<IEnumerable<A02Roles>> GetRoles();
        List<A02Roles> GetRoleslist();
        Task<A02Roles> GetRolesById(long id);

        Task Update(A02Roles A02Roles);

        Task Create(A02Roles A02Roles);

        Task<A02Roles> Delete(long id);
    }
}

using RinkuApp.Persistence.Models;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IA02RolesRepository
    {
        Task<IEnumerable<A02Roles>> GetRoles();
        List<A02Roles> GetRoleslist();
     
        Task<A02Roles> GetRolesById(long id);

        Task Update(A02Roles A02Roles);

        Task Create(A02Roles A02Roles);

        Task<A02Roles> Delete(long id);
    }
}

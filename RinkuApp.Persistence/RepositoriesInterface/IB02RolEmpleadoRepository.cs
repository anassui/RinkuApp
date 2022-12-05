using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IB02RolEmpleadoRepository
    {
        Task<IEnumerable<B02RolEmpleado>> GetEmpleadoRol();

        List<B02RolEmpleado> GetRolesXEmpleadolist();
        B02RolEmpleado GetRolByIdEmpleado(string IdEmpleado);
        List<EmpleadosRoles> GetRolEmpleadoView(string IdEmpleado);
        Task<B02RolEmpleado> GetRolEmpleadoById(long id);

        Task Update(B02RolEmpleado B02RolEmpleado);

        Task Create(B02RolEmpleado B02RolEmpleado);

        Task<B02RolEmpleado> Delete(long id);
    }
}

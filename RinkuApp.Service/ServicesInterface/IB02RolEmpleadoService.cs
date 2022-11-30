using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IB02RolEmpleadoService
    {
        Task<IEnumerable<B02RolEmpleado>> GetEmpleadoRol();

        Task<B02RolEmpleado> GetRolEmpleadoById(long id);

        Task Update(B02RolEmpleado B02RolEmpleado);

        Task Create(B02RolEmpleado B02RolEmpleado);

        Task<B02RolEmpleado> Delete(long id);
    }
}

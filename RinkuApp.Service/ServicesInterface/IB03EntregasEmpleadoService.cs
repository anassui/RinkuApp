using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp. Services.ServicesInterface
{
    public interface IB03EntregasEmpleadoService
    {

        Task<IEnumerable<B03EntregasEmpleado>> GetEntregasEmpleado();

        Task<B03EntregasEmpleado> GetEntregasEmpleadoById(long id);

        Task Update(B03EntregasEmpleado B03EntregasEmpleado);

        Task Create(B03EntregasEmpleado B03EntregasEmpleado);

        Task<B03EntregasEmpleado> Delete(long id);
    }
}

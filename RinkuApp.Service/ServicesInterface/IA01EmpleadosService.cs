using RinkuApp.Persistence.Models;

namespace RinkuApp.Services.ServicesInterface
{
    public interface IA01EmpleadosService
    {
        Task<IEnumerable<A01Empleados>> GetEmpleados();
        List<A01Empleados> GetEmpleadoslist();

        Task<A01Empleados> GetEmpleadosById(long id);

        Task Update(A01Empleados A01Empleados);

        Task Create(A01Empleados A01Empleados);

        Task<A01Empleados> Delete(long id);

    }
}

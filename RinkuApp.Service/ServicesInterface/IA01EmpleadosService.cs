using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;

namespace RinkuApp.Services.ServicesInterface
{
    public interface IA01EmpleadosService
    {
        Task<IEnumerable<A01Empleados>> GetEmpleados();
        Task<A01Empleados> GeEmpleadosById(long id);
        List<A01Empleados> GetEmpleadoslist();
        public List<ReporteNomina> GetReporteNomina(string IdEmpleado);

        Task Update(A01Empleados A01Empleados);

        Task Create(A01Empleados A01Empleados);

        Task<A01Empleados> Delete(long id);

    }
}

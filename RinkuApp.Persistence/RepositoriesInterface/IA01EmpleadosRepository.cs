using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IA01EmpleadosRepository
    {
        Task<IEnumerable<A01Empleados>> GetEmpleados();
        List<EmpleadoModel> GetEmpleadoslist();
        Task<A01Empleados> GeEmpleadosById(long id);
        List<EmpleadoModel> GeEmpleadosViewById(long id);
        public List<ReporteNomina> GetReporteNomina(string IdEmpleado);
        Task Update(A01Empleados A01Empleados);

        Task Create(A01Empleados A01Empleados);

        Task<A01Empleados> Delete(long id);

    }
}

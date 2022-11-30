using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;

namespace RinkuApp.Persistence.Repositories
{
    public class A01EmpleadosService : IA01EmpleadosService
    {
        private readonly IA01EmpleadosRepository _repository;

        public A01EmpleadosService(IA01EmpleadosRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<A01Empleados>> GetEmpleados()
        {
            return await _repository.GetEmpleados().ConfigureAwait(false);
        }

        public async Task<A01Empleados> GetEmpleadosById(long id)
        {
            return await _repository.GetEmpleadosById(id).ConfigureAwait(false);
        }

        public async Task Update(A01Empleados A01Empleados)
        {
            await _repository.Update(A01Empleados).ConfigureAwait(false);
        }

        public async Task Create(A01Empleados A01Empleados)
        {

            await _repository.Create(A01Empleados).ConfigureAwait(false);
        }

        public async Task<A01Empleados> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }

   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using RinkuApp. Services.ServicesInterface;

namespace RinkuApp.Service.Services
{
    public class B02RolEmpleadoService: IB02RolEmpleadoService
    {
        private readonly IB02RolEmpleadoRepository _repository;

        public B02RolEmpleadoService(IB02RolEmpleadoRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<B02RolEmpleado>> GetEmpleadoRol()
        {
            return await _repository.GetEmpleadoRol().ConfigureAwait(false);
        }

        public async Task<B02RolEmpleado> GetRolEmpleadoById(long id)
        {
            return await _repository.GetRolEmpleadoById(id).ConfigureAwait(false);
        }

        public async Task Update(B02RolEmpleado B02RolEmpleado)
        {
            await _repository.Update(B02RolEmpleado).ConfigureAwait(false);
        }

        public async Task Create(B02RolEmpleado B02RolEmpleado)
        {

            await _repository.Create(B02RolEmpleado).ConfigureAwait(false);
        }

        public async Task<B02RolEmpleado> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }

        public List<B02RolEmpleado> GetRolesXEmpleadolist()
        {
            return _repository.GetRolesXEmpleadolist();
        }

    }
}

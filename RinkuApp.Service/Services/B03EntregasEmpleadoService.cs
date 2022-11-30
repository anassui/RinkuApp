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
    public class B03EntregasEmpleadoService: IB03EntregasEmpleadoService
    {
        private readonly IB03EntregasEmpleadoRepository _repository;

        public B03EntregasEmpleadoService(IB03EntregasEmpleadoRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<B03EntregasEmpleado>> GetEntregasEmpleado()
        {
            return await _repository.GetEntregasEmpleado().ConfigureAwait(false);
        }

        public async Task<B03EntregasEmpleado> GetEntregasEmpleadoById(long id)
        {
            return await _repository.GetEntregasEmpleadoById(id).ConfigureAwait(false);
        }

        public async Task Update(B03EntregasEmpleado B03EntregasEmpleado)
        {
            await _repository.Update(B03EntregasEmpleado).ConfigureAwait(false);
        }

        public async Task Create(B03EntregasEmpleado B03EntregasEmpleado)
        {

            await _repository.Create(B03EntregasEmpleado).ConfigureAwait(false);
        }

        public async Task<B03EntregasEmpleado> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }

 
    }
}

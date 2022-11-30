using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using RinkuApp.Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Service.Services
{
    public class B01SalariosService : IB01SalariosService
    {
        private readonly IB01SalariosRepository _repository;

        public  B01SalariosService(IB01SalariosRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable< B01Salarios>> GetSalarios()
        {
            return await _repository.GetSalarios().ConfigureAwait(false);
        }

        public async Task< B01Salarios> GetSalariosById(long id)
        {
            return await _repository.GetSalariosById(id).ConfigureAwait(false);
        }

        public async Task Update( B01Salarios  B01Salarios)
        {
            await _repository.Update( B01Salarios).ConfigureAwait(false);
        }

        public async Task Create( B01Salarios  B01Salarios)
        {

            await _repository.Create( B01Salarios).ConfigureAwait(false);
        }

        public async Task< B01Salarios> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }
     
    }
}

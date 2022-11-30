using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.RepositoriesInterface
{
    public interface IB01SalariosRepository
    {
        Task<IEnumerable<B01Salarios>> GetSalarios();

        Task<B01Salarios> GetSalariosById(long id);

        Task Update(B01Salarios B01Salarios);

        Task Create(B01Salarios B01Salarios);

        Task<B01Salarios> Delete(long id);
    }
}

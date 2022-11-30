using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp. Services.ServicesInterface
{
   public interface IX01ParametrosGeneralesService
    {
        Task<IEnumerable<X01ParametrosGenerales>> GetX01ParametrosGenerales();

        Task<X01ParametrosGenerales> GetX01ParametrosGeneralesById(long id);

        Task Update(X01ParametrosGenerales X01ParametrosGenerales);

        Task Create(X01ParametrosGenerales X01ParametrosGenerales);

        Task<X01ParametrosGenerales> Delete(long id);
    }
}

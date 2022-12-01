using RinkuApp.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp. Services.ServicesInterface
{
   public interface IBitacoraHorasLaboradasService
    {
        Task<IEnumerable<BitacoraHorasLaboradas>> GetBitacoraHorasLaboradas();
        List<BitacoraHorasLaboradas> GetBitacoraHorasLaboradaslist();
        Task<BitacoraHorasLaboradas> GetBitacoraHorasLaboradasById(long id);

        Task Update(BitacoraHorasLaboradas BitacoraHorasLaboradas);

        Task Create(BitacoraHorasLaboradas BitacoraHorasLaboradas);

        Task<BitacoraHorasLaboradas> Delete(long id);
    }
}

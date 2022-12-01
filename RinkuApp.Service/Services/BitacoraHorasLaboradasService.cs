using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using RinkuApp. Services.ServicesInterface;
namespace RinkuApp.Service.Services
{
    public class BitacoraHorasLaboradasService: IBitacoraHorasLaboradasService
    {
        private readonly IBitacoraHorasLaboradasRepository _repository;

        public BitacoraHorasLaboradasService(IBitacoraHorasLaboradasRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<BitacoraHorasLaboradas>> GetBitacoraHorasLaboradas()
        {
            return await _repository.GetBitacoraHorasLaboradas().ConfigureAwait(false);
        }

        public async Task<BitacoraHorasLaboradas> GetBitacoraHorasLaboradasById(long id)
        {
            return await _repository.GetBitacoraHorasLaboradasById(id).ConfigureAwait(false);
        }

        public async Task Update(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {
            await _repository.Update(BitacoraHorasLaboradas).ConfigureAwait(false);
        }

        public async Task Create(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {

            await _repository.Create(BitacoraHorasLaboradas).ConfigureAwait(false);
        }

        public async Task<BitacoraHorasLaboradas> Delete(long id)
        {
            return await _repository.Delete(id).ConfigureAwait(false);
        }
        public List<BitacoraHorasLaboradas> GetBitacoraHorasLaboradaslist()
        {
            return _repository.GetBitacoraHorasLaboradaslist();
        }

    }
}

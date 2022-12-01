using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;

namespace RinkuApp.Persistence.Repositories
{
    public class BitacoraHorasLaboradasRepository: IBitacoraHorasLaboradasRepository
    {
        private readonly AppDbContext _context;

        public BitacoraHorasLaboradasRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BitacoraHorasLaboradas>> GetBitacoraHorasLaboradas()
        {
            return await _context.BitacoraHorasLaboradas.ToListAsync();
        }

        public async Task<BitacoraHorasLaboradas> GetBitacoraHorasLaboradasById(long id)
        {
            return await _context.BitacoraHorasLaboradas.FindAsync(id);
        }

        public async Task Update(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {
            _context.Entry(BitacoraHorasLaboradas).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BitacoraHorasLaboradasExists(BitacoraHorasLaboradas.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {
            _context.BitacoraHorasLaboradas.Add(BitacoraHorasLaboradas);
            await _context.SaveChangesAsync();
        }

        public async Task<BitacoraHorasLaboradas> Delete(long id)
        {

            var BitacoraHorasLaboradas = await _context.BitacoraHorasLaboradas.FindAsync(id);
            if (BitacoraHorasLaboradas is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.BitacoraHorasLaboradas.Remove(BitacoraHorasLaboradas);
            await _context.SaveChangesAsync();

            return BitacoraHorasLaboradas;
        }


        private bool BitacoraHorasLaboradasExists(long id)
        {
            return _context.BitacoraHorasLaboradas.Any(obj => obj.Id == id);
        }

        public List<BitacoraHorasLaboradas> GetBitacoraHorasLaboradaslist()
        {
            return _context.BitacoraHorasLaboradas.ToList();
        }
    }
}

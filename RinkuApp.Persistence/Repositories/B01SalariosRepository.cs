using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.Repositories
{
    public class B01SalariosRepository : IB01SalariosRepository
    {
        private readonly AppDbContext _context;

        public  B01SalariosRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable< B01Salarios>> GetSalarios()
        {
            return await _context. B01Salarios.ToListAsync();
        }

        public async Task< B01Salarios> GetSalariosById(long id)
        {
            return await _context. B01Salarios.FindAsync(id);
        }

        public async Task Update( B01Salarios  B01Salarios)
        {
            _context.Entry( B01Salarios).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! B01SalariosExists( B01Salarios.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create( B01Salarios  B01Salarios)
        {
            _context. B01Salarios.Add( B01Salarios);
            await _context.SaveChangesAsync();
        }

        public async Task< B01Salarios> Delete(long id)
        {

            var  B01Salarios = await _context. B01Salarios.FindAsync(id);
            if ( B01Salarios is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context. B01Salarios.Remove( B01Salarios);
            await _context.SaveChangesAsync();

            return  B01Salarios;
        }





        private bool  B01SalariosExists(long id)
        {
            return _context. B01Salarios.Any(obj => obj.Id == id);
        }

        public List<B01Salarios> GetSalarioslist()
        {
            return _context.B01Salarios.ToList();
        }
    }
}

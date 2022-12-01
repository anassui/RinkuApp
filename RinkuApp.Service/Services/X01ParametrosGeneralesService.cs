using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp. Services.ServicesInterface;

namespace RinkuApp.Service.Services
{
    public class X01ParametrosGeneralesService: IX01ParametrosGeneralesService
    {
        private readonly AppDbContext _context;

        public X01ParametrosGeneralesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<X01ParametrosGenerales>> GetX01ParametrosGenerales()
        {
            return await _context.X01ParametrosGenerales.ToListAsync();
        }

        public async Task<X01ParametrosGenerales> GetX01ParametrosGeneralesById(long id)
        {
            return await _context.X01ParametrosGenerales.FindAsync(id);
        }

        public async Task Update(X01ParametrosGenerales X01ParametrosGenerales)
        {
            _context.Entry(X01ParametrosGenerales).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!X01ParametrosGeneralesExists(X01ParametrosGenerales.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(X01ParametrosGenerales X01ParametrosGenerales)
        {
            _context.X01ParametrosGenerales.Add(X01ParametrosGenerales);
            await _context.SaveChangesAsync();
        }

        public async Task<X01ParametrosGenerales> Delete(long id)
        {

            var X01ParametrosGenerales = await _context.X01ParametrosGenerales.FindAsync(id);
            if (X01ParametrosGenerales is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.X01ParametrosGenerales.Remove(X01ParametrosGenerales);
            await _context.SaveChangesAsync();

            return X01ParametrosGenerales;
        }

        private bool X01ParametrosGeneralesExists(long id)
        {
            return _context.X01ParametrosGenerales.Any(obj => obj.Id == id);
        }

        public List<X01ParametrosGenerales> GetX01ParametrosGeneraleslist()
        {
            throw new NotImplementedException();
        }
    }
}

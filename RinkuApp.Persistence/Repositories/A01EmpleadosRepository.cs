using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;

namespace RinkuApp.Persistence.Repositories
{
    public class A01EmpleadosRepository : IA01EmpleadosRepository
    {
        private readonly AppDbContext _context;

        public A01EmpleadosRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<A01Empleados>> GetEmpleados()
        {
            return await _context.A01Empleados.ToListAsync();
        }

        public async Task<A01Empleados> GetEmpleadosById(long id)
        {
            return await _context.A01Empleados.FindAsync(id);
        }

        public async Task Update(A01Empleados A01Empleados)
        {
            _context.Entry(A01Empleados).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!A01EmpleadosExists(A01Empleados.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(A01Empleados A01Empleados)
        {
            _context.A01Empleados.Add(A01Empleados);
            await _context.SaveChangesAsync();
        }

        public async Task<A01Empleados> Delete(long id)
        {

            var A01Empleados = await _context.A01Empleados.FindAsync(id);
            if (A01Empleados is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.A01Empleados.Remove(A01Empleados);
            await _context.SaveChangesAsync();

            return A01Empleados;
        }

   

        

        private bool A01EmpleadosExists(long id)
        {
            return _context.A01Empleados.Any(obj => obj.Id == id);
        }



    }
}

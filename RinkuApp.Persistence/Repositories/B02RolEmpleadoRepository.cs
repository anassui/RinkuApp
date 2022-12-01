using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;

namespace RinkuApp.Persistence.Repositories
{
    public class B02RolEmpleadoRepository: IB02RolEmpleadoRepository
    {
        private readonly AppDbContext _context;

        public  B02RolEmpleadoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<B02RolEmpleado>> GetEmpleadoRol()
        {
            return await _context. B02RolEmpleado.ToListAsync();
        }

        public async Task<B02RolEmpleado> GetRolEmpleadoById(long id)
        {
            return await _context.B02RolEmpleado.FindAsync(id);
        }

        public async Task Update( B02RolEmpleado  B02RolEmpleado)
        {
            _context.Entry(B02RolEmpleado).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! B02RolEmpleadoExists(B02RolEmpleado.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(B02RolEmpleado B02RolEmpleado)
        {
            _context. B02RolEmpleado.Add(B02RolEmpleado);
            await _context.SaveChangesAsync();
        }

        public async Task< B02RolEmpleado> Delete(long id)
        {

            var  B02RolEmpleado = await _context.B02RolEmpleado.FindAsync(id);
            if ( B02RolEmpleado is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.B02RolEmpleado.Remove( B02RolEmpleado);
            await _context.SaveChangesAsync();

            return  B02RolEmpleado;
        }


        private bool  B02RolEmpleadoExists(long id)
        {
            return _context.B02RolEmpleado.Any(obj => obj.Id == id);
        }

        public List<B02RolEmpleado> GetRolesXEmpleadolist()
        {
            return _context.B02RolEmpleado.ToList();
        }
    }
}

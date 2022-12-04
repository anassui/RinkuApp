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
    public class A02RolesRepository : IA02RolesRepository
    {
        private readonly AppDbContext _context;

        public A02RolesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<A02Roles>> GetRoles()
        {
            return await _context.A02Roles.ToListAsync();
        }

        public async Task<A02Roles> GetRolesById(long id)
        {
            return await _context.A02Roles.FindAsync(id) ?? throw new ArgumentNullException("No se encontro información del Rol."); ;
        }

        public async Task Update(A02Roles A02Roles)
        {
            _context.Entry(A02Roles).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!A02RolesExists(A02Roles.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(A02Roles A02Roles)
        {
            _context.A02Roles.Add(A02Roles);
            await _context.SaveChangesAsync();
        }

        public async Task<A02Roles> Delete(long id)
        {

            var A02Roles = await _context.A02Roles.FindAsync(id);
            if (A02Roles is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.A02Roles.Remove(A02Roles);
            await _context.SaveChangesAsync();

            return A02Roles;
        }


        private bool A02RolesExists(long id)
        {
            return _context.A02Roles.Any(obj => obj.Id == id);
        }

        public List<A02Roles> GetRoleslist()
        {
            return _context.A02Roles.ToList();
        }
    }
}

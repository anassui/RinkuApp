using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
namespace RinkuApp.Persistence.Repositories
{
    public class B03EntregasEmpleadoRepository : IB03EntregasEmpleadoRepository
    {
        private readonly AppDbContext _context;

        public B03EntregasEmpleadoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<B03EntregasEmpleado>> B03EntregasEmpleadoExists()
        {
            return await _context.B03EntregasEmpleado.ToListAsync();
        }

        public async Task<B03EntregasEmpleado> GetEntregasEmpleadoById(long id)
        {
            return await _context.B03EntregasEmpleado.FindAsync(id) ?? throw new ArgumentNullException("No se encontro información de entregas."); ;
        }

        public async Task Update(B03EntregasEmpleado B03EntregasEmpleado)
        {
            _context.Entry(B03EntregasEmpleado).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!B03EntregasEmpleadoExists(B03EntregasEmpleado.Id))
                {
                    throw new ArgumentException("El Usuario no existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Create(B03EntregasEmpleado B03EntregasEmpleado)
        {
            _context.B03EntregasEmpleado.Add(B03EntregasEmpleado);
            await _context.SaveChangesAsync();
        }

        public async Task<B03EntregasEmpleado> Delete(long id)
        {

            var B03EntregasEmpleado = await _context.B03EntregasEmpleado.FindAsync(id);
            if (B03EntregasEmpleado is null)
            {
                throw new ArgumentException("El Usuario no existe");
            }
            _context.B03EntregasEmpleado.Remove(B03EntregasEmpleado);
            await _context.SaveChangesAsync();

            return B03EntregasEmpleado;
        }





        private bool B03EntregasEmpleadoExists(long id)
        {
            return _context.B03EntregasEmpleado.Any(obj => obj.Id == id);
        }

        public Task<IEnumerable<B03EntregasEmpleado>> GetEntregasEmpleado()
        {
            throw new NotImplementedException();
        }

        public List<B03EntregasEmpleado> GetEntregasXEmpleadolist()
        {
            return _context.B03EntregasEmpleado.ToList();
        }


        public List<EntregasEmpleadoView> GetEntregasView(string IdEmpleado)
        {
            IQueryable<EntregasEmpleadoView> entryPoint = (from src in _context.B03EntregasEmpleado
                                                        join B02 in _context.B02RolEmpleado on new { Empleado = src.IdEmpleado } equals new { Empleado = B02.IdEmpleado } into joinRolEmpleado
                                                        from joinB02 in joinRolEmpleado.DefaultIfEmpty()
                                                        join Empleados in _context.A01Empleados on new { Empleado = src.IdEmpleado } equals new { Empleado = Empleados.IdEmpleado } into joinEmpleados
                                                        from joinA01 in joinEmpleados.DefaultIfEmpty()
                                                    select new EntregasEmpleadoView
                                                    {
                                                        Id = src.Id,
                                                        IdEmpleado = src.IdEmpleado,
                                                        Nombre = joinA01.Nombre,
                                                        Rol = joinB02.IdRol,
                                                        CantidadEntregas = src.CantidadEntregas,
                                                        FechaEntrega = src.FechaEntrega,
                                                        CreatedBy = src.CreatedBy,
                                                        CreatedOn = src.CreatedOn,
                                                        LastModifiedBy = src.LastModifiedBy,
                                                        LastModifiedOn = src.LastModifiedOn,

                                                    });
            return entryPoint.Where(e => e.IdEmpleado == IdEmpleado).ToList();
        }
    }
}

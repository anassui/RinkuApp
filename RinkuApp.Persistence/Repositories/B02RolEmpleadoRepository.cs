using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.DTOs;
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
            return await _context.B02RolEmpleado.ToListAsync();
        }

        public async Task<B02RolEmpleado> GetRolEmpleadoById(long id)
        {
            return await _context.B02RolEmpleado.FindAsync(id) ?? throw new ArgumentNullException("No se encontro información del rol empleado.") ;
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
                    throw new ArgumentException("El RolEmpleado no existe");
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
                throw new ArgumentException("El RolEmpleado no existe");
            }
            _context.B02RolEmpleado.Remove( B02RolEmpleado);
            await _context.SaveChangesAsync();

            return  B02RolEmpleado;
        }


        private bool B02RolEmpleadoExists(long id)
        {
            return _context.B02RolEmpleado.Any(obj => obj.Id == id);
        }

        public List<B02RolEmpleado> GetRolesXEmpleadolist()
        {
            return _context.B02RolEmpleado.ToList();
        }

        public List<EmpleadosRoles> GetRolEmpleadoView(string IdEmpleado)
        {
            IQueryable<EmpleadosRoles> entryPoint = (from src in _context.B02RolEmpleado
                                                    join A01 in _context.A01Empleados on new { Empleado = src.IdEmpleado } equals new { Empleado = A01.IdEmpleado } into joinEmpleado
                                                     from joinA01 in joinEmpleado.DefaultIfEmpty()
                                                    select new EmpleadosRoles
                                                    {
                                                        Id = src.Id,
                                                        IdEmpleado = src.IdEmpleado,
                                                        Nombre = joinA01.Nombre,
                                                        IdRol = src.IdRol,
                                                        FechaComienzoRol = src.FechaComienzoRol,
                                                        Estatus = joinA01.Estatus,
                                                        CreatedOn = src.CreatedOn,
                                                    });
            return entryPoint.Where(x=> x.IdEmpleado == IdEmpleado).ToList();
        }

        public B02RolEmpleado GetRolByIdEmpleado(string IdEmpleado)
        {
            return _context.B02RolEmpleado.Where(x => x.IdEmpleado == IdEmpleado).AsNoTracking().FirstOrDefault() ?? throw new ArgumentNullException("No se encontro información del rol empleado.") ; 
        }
    }
}

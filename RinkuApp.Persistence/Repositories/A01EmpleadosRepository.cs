using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using System.Net.NetworkInformation;

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
                    throw new ArgumentException("El Empleado no existe");
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
                throw new ArgumentException("El Empleado no existe");
            }
            _context.A01Empleados.Remove(A01Empleados);
            await _context.SaveChangesAsync();

            return A01Empleados;
        }

        private bool A01EmpleadosExists(long id)
        {
            return _context.A01Empleados.Any(obj => obj.Id == id);
        }

        public List<EmpleadoModel> GetEmpleadoslist()
        {
            IQueryable<EmpleadoModel> entryPoint = (from src in _context.A01Empleados
                                                    join B02 in _context.B02RolEmpleado on new { Empleado = src.IdEmpleado } equals new { Empleado = B02.IdEmpleado } into joinRolEmpleado
                                                    from joinB02 in joinRolEmpleado.DefaultIfEmpty()
                                                    select new EmpleadoModel
                                                    {
                                                        Id = src.Id,
                                                        IdEmpleado = src.IdEmpleado,
                                                        IdRol = joinB02.IdRol,
                                                        Nombre = src.Nombre,
                                                        Apellidos = src.Apellidos,
                                                        Edad = src.Edad,
                                                        Sexo = src.Sexo,
                                                        Email = src.Email,
                                                        Telefono = src.Telefono,
                                                        Direccion = src.Direccion,
                                                        Estatus = src.Estatus,
                                                        CreatedBy = src.CreatedBy,
                                                        CreatedOn = src.CreatedOn,
                                                        LastModifiedBy = src.LastModifiedBy,
                                                        LastModifiedOn = src.LastModifiedOn,

                                                    });
            return entryPoint.ToList();
        }

        public List<ReporteNomina> GetReporteNomina(string IdEmpleado)
        {
            IQueryable<ReporteNomina> entryPoint = (from src in _context.A01Empleados
                                                    join B02 in _context.B02RolEmpleado on new { Empleado = src.IdEmpleado } equals new { Empleado = B02.IdEmpleado } into joinRolEmpleado
                                                        from joinB02 in joinRolEmpleado.DefaultIfEmpty()
                                                        join Salario in _context.B01Salarios on new { Empleado = src.IdEmpleado } equals new { Empleado = Salario.IdEmpleado } into joinSalario
                                                        from joinB01 in joinSalario.DefaultIfEmpty()
                                                    join Entregas in _context.B03EntregasEmpleado on new { Empleado = src.IdEmpleado } equals new { Empleado = Entregas.IdEmpleado } into joinEntregas
                                                    from joinB03 in joinEntregas.DefaultIfEmpty()
                                                    select new ReporteNomina
                                                        {
                                                            Id = src.Id,
                                                            IdEmpleado = src.IdEmpleado,
                                                            IdRol = joinB02.IdRol,
                                                            Salario = joinB01.Salario,
                                                            CantidadEntregas = joinB03.CantidadEntregas,
                                                            TotalHorasLaboradas = 40,
                                                            ISR = 9,

                                                    });
            return entryPoint.Where(e=>e.IdEmpleado == IdEmpleado).ToList();
        }

        public async Task<A01Empleados> GeEmpleadosById(long id)
        {
            return await _context.A01Empleados.FindAsync(id) ?? throw new ArgumentNullException("No se encontro información del empleado.");
        }


        public List<EmpleadoModel> GeEmpleadosViewById(long id)
        {
            IQueryable<EmpleadoModel> entryPoint = (from src in _context.A01Empleados
                                                    join B02 in _context.B02RolEmpleado on new { Empleado = src.IdEmpleado } equals new { Empleado = B02.IdEmpleado } into joinRolEmpleado
                                                    from joinB02 in joinRolEmpleado.DefaultIfEmpty()
                                                    select new EmpleadoModel
                                                    {
                                                        Id = src.Id,
                                                        IdEmpleado = src.IdEmpleado,
                                                        IdRol = joinB02.IdRol,
                                                        Nombre = src.Nombre,
                                                        Apellidos = src.Apellidos,
                                                        Edad = src.Edad,
                                                        Sexo = src.Sexo,
                                                        Email = src.Email,
                                                        Telefono = src.Telefono,
                                                        Direccion = src.Direccion,
                                                        Estatus = src.Estatus,
                                                        CreatedBy = src.CreatedBy,
                                                        CreatedOn = src.CreatedOn,
                                                        LastModifiedBy = src.LastModifiedBy,
                                                        LastModifiedOn = src.LastModifiedOn,

                                                    });
            return entryPoint.Where(x=> x.Id == id).ToList();
        }
    }
}

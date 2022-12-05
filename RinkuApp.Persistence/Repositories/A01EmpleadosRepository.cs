using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;
using RinkuApp.Persistence.RepositoriesInterface;
using System.Data.Common;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore.Metadata;

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

            List<ReporteNomina> Result = new List<ReporteNomina>();
            SqlParameter[] parameters =
            {

                new SqlParameter
                {
                    ParameterName = "IdEmpleado",
                    Value = IdEmpleado,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                }
            };
            try
            {
                using var command = _context.Database.GetDbConnection().CreateCommand();
                command.CommandText = "SP_Reporte_Nomina @IdEmpleado";
                command.Parameters.AddRange(parameters);
                command.CommandTimeout = 18000;
                _context.Database.OpenConnection();
                DbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReporteNomina reporte = new ReporteNomina();
                    reporte.IdEmpleado = reader["IdEmpleado"].ToString();
                    reporte.Nombre = reader["Nombre"].ToString();
                    reporte.Email = reader["Email"].ToString();
                    reporte.Telefono = reader["Telefono"].ToString();
                    reporte.Apellidos = reader["Apellidos"].ToString();
                    reporte.IdRol = reader["IdRol"].ToString();
                    reporte.SalarioBase = reader["SalarioBase"].ToString();
                    reporte.BonoXHora = reader["BonoXHora"].ToString();
                    reporte.SalarioBaseXMes = reader["SalarioBaseXMes"].ToString();
                    reporte.EntregasXMes = reader["EntregasXMes"].ToString();
                    reporte.Mes = reader["Mes"].ToString();
                    reporte.AcumuladoBonosXEntrega = reader["AcumuladoBonosXEntrega"].ToString();
                    reporte.AcumuladoBonoXRol = reader["AcumuladoBonoXRol"].ToString();
                    reporte.SalarioBruto = reader["SalarioBruto"].ToString();
                    reporte.ISR = reader["ISR"].ToString();
                    reporte.ImpuestosAdicionales = reader["ImpuestosAdicionales"].ToString();
                    reporte.ValesDespensa = reader["ValesDespensa"].ToString();
                    Result.Add(reporte);

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                _context.Database.CloseConnection();
                return new List<ReporteNomina>();
            }
            finally
            {
                _context.Database.CloseConnection();
            }
            return Result;
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.DTOs;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class A01EmpleadosController : Controller
    {
        private readonly IA01EmpleadosService _service;
        private readonly IA02RolesService _serviceA02;
        private readonly IB02RolEmpleadoService _serviceB02;
        private readonly ILogger<A01EmpleadosController> _logger;
        public A01EmpleadosController(IA01EmpleadosService service, ILogger<A01EmpleadosController> logger, IA02RolesService serviceA02, IB02RolEmpleadoService serviceB02)
        {
            _service = service;
            _logger = logger;
            _serviceA02 = serviceA02;
            _serviceB02 = serviceB02;
        }
        public IActionResult Index()
        {
            var Empleados = _service.GetEmpleadoslist();
            this.ViewBag.Empleados = Empleados;
            return this.View();
        }

        [Route("Formulario/{id}")]
        public IActionResult Formulario(long id)
        {
            this.ViewBag.Details = null;

            if (id != 0)
            {
                this.ViewBag.Details = _service.GeEmpleadosViewById(id)[0];
            }
            this.ViewBag.Roles = _serviceA02.GetRoleslist();
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<A01Empleados>> GetAll()
        {
            return await _service.GetEmpleados().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<A01Empleados> GetById(long id)
        {
            return await _service.GeEmpleadosById(id).ConfigureAwait(false);
        }

        // POST: A01EmpleadossController/Create
        [HttpPost]
        [Route("Create")]
        public async Task Create(EmpleadoModel EmpleadoModel)
        {
            A01Empleados A01Empleados = new A01Empleados(EmpleadoModel);
            B02RolEmpleado B02RolEmpleado = new B02RolEmpleado(EmpleadoModel);
            try
            {
                await _service.Create(A01Empleados).ConfigureAwait(false);
                await _serviceB02.Create(B02RolEmpleado).ConfigureAwait(false);

            }
            catch
            {
                throw new ArgumentException("Fallo creación de Empleado");
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(EmpleadoModel EmpleadoModel)
        {
            A01Empleados A01Empleados = new A01Empleados(EmpleadoModel);
            

            try
            {
                await _service.Update(A01Empleados).ConfigureAwait(false);

                var idB02 = _serviceB02.GetRolByIdEmpleado(A01Empleados.IdEmpleado == null ? "" : A01Empleados.IdEmpleado);
                B02RolEmpleado B02RolEmpleado = new B02RolEmpleado(EmpleadoModel);
                B02RolEmpleado.Id = idB02.Id; // se busca el id a actualizar del mismo Empleado
                await _serviceB02.Update(B02RolEmpleado).ConfigureAwait(false);
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task Delete(long id)
        {
            try
            {
                await _service.Delete(id).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo eliminacion de Empleado");
            }
        }


    }
}

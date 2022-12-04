using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class A01EmpleadosController : Controller
    {
        private readonly IA01EmpleadosService _service;
        private readonly ILogger<A01EmpleadosController> _logger;
        public A01EmpleadosController(IA01EmpleadosService service, ILogger<A01EmpleadosController> logger)
        {
            _service = service;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var Empleados = _service.GetEmpleadoslist();
            this.ViewBag.Empleados = Empleados;
            return this.View();
        }

        [Route("Formulario/{id}")]
        public async Task<IActionResult> Formulario(long id)
        {
            this.ViewBag.Details = null;

            if (id != 0)
            {
                this.ViewBag.Details = await _service.GeEmpleadosById(id).ConfigureAwait(false);
            }
           
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
        public async Task Create(A01Empleados A01Empleados)
        {
            try
            {
                A01Empleados.IdEmpleado = Guid.NewGuid().ToString();
                await _service.Create(A01Empleados).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(A01Empleados A01Empleados)
        {
            try
            {
                await _service.Update(A01Empleados).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
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
                throw new ArgumentException("Fallo eliminacion de usuario");
            }
        }


    }
}

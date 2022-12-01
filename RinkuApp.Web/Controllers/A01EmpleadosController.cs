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

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<A01Empleados>> GetAll()
        {
            return await _service.GetEmpleados().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<A01Empleados> GetById(long id)
        {
            return await _service.GetEmpleadosById(id).ConfigureAwait(false);
        }

        // POST: A01EmpleadossController/Create
        [HttpPost]
        public async Task Create(A01Empleados A01Empleados)
        {
            try
            {
                await _service.Create(A01Empleados).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        // POST: A01EmpleadossController/Create
        [HttpPut]
        [Route("update")]
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
        [Route("delete")]
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

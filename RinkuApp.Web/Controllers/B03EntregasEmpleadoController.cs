using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class B03EntregasEmpleadoController : Controller
    {
        private readonly IB03EntregasEmpleadoService _service;
        private readonly IA01EmpleadosService _serviceA01;
        private readonly ILogger<B03EntregasEmpleadoController> _logger;
        public B03EntregasEmpleadoController(IB03EntregasEmpleadoService service, ILogger<B03EntregasEmpleadoController> logger, IA01EmpleadosService serviceA01)
        {
            _service = service;
            _logger = logger;
            _serviceA01 = serviceA01;
        }

        [HttpGet]
        [Route("{idEmpleado}")]
        public IActionResult Index(string idEmpleado)
        {
            var entregasEmpleados = _service.GetEntregasView(idEmpleado);
            this.ViewBag.entregasEmpleados = entregasEmpleados;
            this.ViewBag.Nombre = entregasEmpleados[0].Nombre;
            return this.View();
        }


        [Route("Formulario/{id}")]
        public async Task<IActionResult> Formulario(long id)
        {
            this.ViewBag.Details = null;

            if (id != 0)
            {
                //this.ViewBag.Details = await _service.GetEntregasEmpleadoById(id).ConfigureAwait(false);
                this.ViewBag.Details = await _serviceA01.GeEmpleadosById(id).ConfigureAwait(false);
            }
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<B03EntregasEmpleado>> GetAll()
        {
            return await _service.GetEntregasEmpleado().ConfigureAwait(false);
        }

        // POST: B03EntregasEmpleadosController/Create
        [HttpPost]
        [Route("Create")]
        public async Task Create(B03EntregasEmpleado B03EntregasEmpleado)
        {
            try
            {
                await _service.Create(B03EntregasEmpleado).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de Entrega");
            }
        }

        // POST: B03EntregasEmpleadosController/Create
        [HttpPut]
        [Route("update")]
        public async Task Update(B03EntregasEmpleado B03EntregasEmpleado)
        {
            try
            {
                await _service.Update(B03EntregasEmpleado).ConfigureAwait(false);
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Controllers
{
    public class B03EntregasEmpleadoController : ControllerBase
    {
        private readonly IB03EntregasEmpleadoService _service;

        public B03EntregasEmpleadoController(IB03EntregasEmpleadoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<B03EntregasEmpleado>> GetAll()
        {
            return await _service.GetEntregasEmpleado().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<B03EntregasEmpleado> GetById(long id)
        {
            return await _service.GetEntregasEmpleadoById(id).ConfigureAwait(false);
        }

        // POST: B03EntregasEmpleadosController/Create
        [HttpPost]
        public async Task Create(B03EntregasEmpleado B03EntregasEmpleado)
        {
            try
            {
                await _service.Create(B03EntregasEmpleado).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
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

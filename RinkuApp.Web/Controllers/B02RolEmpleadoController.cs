using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Controllers
{
    public class B02RolEmpleadoController : ControllerBase
    {
        private readonly IB02RolEmpleadoService _service;

        public B02RolEmpleadoController(IB02RolEmpleadoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<B02RolEmpleado>> GetAll()
        {
            return await _service.GetEmpleadoRol().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<B02RolEmpleado> GetById(long id)
        {
            return await _service.GetRolEmpleadoById(id).ConfigureAwait(false);
        }

        // POST: B02RolEmpleadosController/Create
        [HttpPost]
        public async Task Create(B02RolEmpleado B02RolEmpleado)
        {
            try
            {
                await _service.Create(B02RolEmpleado).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        // POST: B02RolEmpleadosController/Create
        [HttpPut]
        [Route("update")]
        public async Task Update(B02RolEmpleado B02RolEmpleado)
        {
            try
            {
                await _service.Update(B02RolEmpleado).ConfigureAwait(false);
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

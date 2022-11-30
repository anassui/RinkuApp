using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Controllers
{
    public class B01SalariosController : ControllerBase
    {
        private readonly IB01SalariosService _service;

        public B01SalariosController(IB01SalariosService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<B01Salarios>> GetAll()
        {
            return await _service.GetSalarios().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<B01Salarios> GetById(long id)
        {
            return await _service.GetSalariosById(id).ConfigureAwait(false);
        }

        // POST: B01SalariossController/Create
        [HttpPost]
        public async Task Create(B01Salarios B01Salarios)
        {
            try
            {
                await _service.Create(B01Salarios).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        // POST: B01SalariossController/Create
        [HttpPut]
        [Route("update")]
        public async Task Update(B01Salarios B01Salarios)
        {
            try
            {
                await _service.Update(B01Salarios).ConfigureAwait(false);
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

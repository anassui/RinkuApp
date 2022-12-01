using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class B01SalariosController : Controller
    {
        private readonly IB01SalariosService _service;
        private readonly ILogger<B01SalariosController> _logger;
        public B01SalariosController(IB01SalariosService service, ILogger<B01SalariosController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return this.View();
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

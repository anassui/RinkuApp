using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class X01ParametrosGeneralesController : Controller
    {
        private readonly IX01ParametrosGeneralesService _service;
        private readonly ILogger<X01ParametrosGeneralesController> _logger;
        public X01ParametrosGeneralesController(IX01ParametrosGeneralesService service, ILogger<X01ParametrosGeneralesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var x01ParametrosGenerales = _service.GetX01ParametrosGeneraleslist();
            this.ViewBag.Roles = x01ParametrosGenerales;
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<X01ParametrosGenerales>> GetAll()
        {
        
            return await _service.GetX01ParametrosGenerales().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<X01ParametrosGenerales> GetById(long id)
        {
            return await _service.GetX01ParametrosGeneralesById(id).ConfigureAwait(false);
        }

        // POST: X01ParametrosGeneralessController/Create
        [HttpPost]
        public async Task Create(X01ParametrosGenerales X01ParametrosGenerales)
        {
            try
            {
                await _service.Create(X01ParametrosGenerales).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        // POST: X01ParametrosGeneralessController/Create
        [HttpPut]
        [Route("update")]
        public async Task Update(X01ParametrosGenerales X01ParametrosGenerales)
        {
            try
            {
                await _service.Update(X01ParametrosGenerales).ConfigureAwait(false);
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

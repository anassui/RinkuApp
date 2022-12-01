using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BitacoraHorasLaboradasController : Controller
    {
        private readonly IBitacoraHorasLaboradasService _service;
        private readonly ILogger<BitacoraHorasLaboradasController> _logger;
        public BitacoraHorasLaboradasController(IBitacoraHorasLaboradasService service, ILogger<BitacoraHorasLaboradasController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var bitacoraHorasLaboradas = _service.GetBitacoraHorasLaboradaslist();
            this.ViewBag.bitacoraHorasLaboradas = bitacoraHorasLaboradas;
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<BitacoraHorasLaboradas>> GetAll()
        {
            return await _service.GetBitacoraHorasLaboradas().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<BitacoraHorasLaboradas> GetById(long id)
        {
            return await _service.GetBitacoraHorasLaboradasById(id).ConfigureAwait(false);
        }

        // POST: BitacoraHorasLaboradassController/Create
        [HttpPost]
        public async Task Create(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {
            try
            {
                await _service.Create(BitacoraHorasLaboradas).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de usuario");
            }
        }

        // POST: BitacoraHorasLaboradassController/Create
        [HttpPut]
        [Route("update")]
        public async Task Update(BitacoraHorasLaboradas BitacoraHorasLaboradas)
        {
            try
            {
                await _service.Update(BitacoraHorasLaboradas).ConfigureAwait(false);
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

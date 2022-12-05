using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class A02RolesController : Controller
    {
        private readonly IA02RolesService _service;
        private readonly ILogger<A02RolesController> _logger;
        public A02RolesController(IA02RolesService service, ILogger<A02RolesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Roles = _service.GetRoleslist();
            this.ViewBag.Roles = Roles;
            return this.View();
        }
         
        [Route("Formulario/{id}")]
        public async Task<IActionResult> Formulario(long id)
        {
            this.ViewBag.Details = null;

            if (id != 0)
            {
                this.ViewBag.Details = await _service.GetRolesById(id).ConfigureAwait(false);
            }
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<A02Roles>> GetAll()
        {
            return await _service.GetRoles().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<A02Roles> GetById(long id)
        {
            return await _service.GetRolesById(id).ConfigureAwait(false);
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create(A02Roles A02Roles)
        {
            try
            {
                await _service.Create(A02Roles).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo creación de Rol");
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task Update(A02Roles A02Roles)
        {
            try
            {
                await _service.Update(A02Roles).ConfigureAwait(false);
            }
            catch
            {
                throw new ArgumentException("Fallo Actualización de Rol");
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
                throw new ArgumentException("Fallo eliminacion de Rol");
            }
        }
    }
}

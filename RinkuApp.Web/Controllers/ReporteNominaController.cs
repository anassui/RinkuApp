using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;
using System.Text.Json;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReporteNominaController : Controller
    {
        private readonly IA01EmpleadosService _service;
        private readonly ILogger<ReporteNominaController> _logger;
        public ReporteNominaController(IA01EmpleadosService service, ILogger<ReporteNominaController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IActionResult Index(string id)
        {
             var Reporte = _service.GetReporteNomina(id);
            this.ViewBag.Empleados = Reporte;
            return this.View();
        }

    }
}

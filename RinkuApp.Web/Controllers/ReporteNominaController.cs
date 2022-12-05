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
            var reporteEmpleado = Reporte[0];
            var ISR = Double.Parse(reporteEmpleado.ISR == null ? "0" : reporteEmpleado.ISR);
            var SalarioBruto = Double.Parse(reporteEmpleado.SalarioBruto == null ? "0": reporteEmpleado.SalarioBruto);
            var SalarioNetoAntesImpuestosAdicionales = SalarioBruto - ISR;
            double SalarioNeto;
            if (SalarioBruto > 10000)
            {
                var ImpuestosAdiciones = SalarioBruto * 0.3;
                SalarioNeto = SalarioNetoAntesImpuestosAdicionales - ImpuestosAdiciones;
            }
            else {
                SalarioNeto = SalarioBruto - ISR;
            }
            var BonosDespensa = SalarioNeto * .04;
            this.ViewBag.SalarioNeto = SalarioNeto;
            this.ViewBag.BonosDespensa = BonosDespensa;
            this.ViewBag.Empleados = reporteEmpleado;
            return this.View();
        }

    }
}

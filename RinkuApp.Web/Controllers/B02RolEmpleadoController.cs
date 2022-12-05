﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RinkuApp.Persistence.Models;
using RinkuApp.Services.ServicesInterface;

namespace RinkuApp.Web.Areas.Empleados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class B02RolEmpleadoController : Controller
    {
        private readonly IB02RolEmpleadoService _service;
        private readonly ILogger<B02RolEmpleadoController> _logger;
        public B02RolEmpleadoController(IB02RolEmpleadoService service, ILogger<B02RolEmpleadoController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [Route("{idEmpleado}")]
        public IActionResult Index(string idEmpleado)
        {
            var RolEmpleado = _service.GetRolEmpleadoView(idEmpleado);
            this.ViewBag.RolEmpleado = RolEmpleado;
            return this.View();
        }


        [Route("Formulario/{id}")]
        public async Task<IActionResult> Formulario(long id)
        {
            this.ViewBag.Details = null;

            if (id != 0)
            {
                this.ViewBag.Details = await _service.GetRolEmpleadoById(id).ConfigureAwait(false);
            }
            return this.View();
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IEnumerable<B02RolEmpleado>> GetAll()
        {
            return await _service.GetEmpleadoRol().ConfigureAwait(false);
        }

   
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

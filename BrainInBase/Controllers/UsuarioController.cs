using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainInBaseClass.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        [HttpGet]
        public async Task<IActionResult> FindUsuario ([FromQuery] Usuario filtro)
        {
            return Ok();
        }
    }
}
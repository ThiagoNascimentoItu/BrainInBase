using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/registro/[controller]")]
    public class RegistroController : ControllerBase
    {
        private readonly ILogger<RegistroController> logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/comprovante/[controller]")]
    public class ComprovanteController : ControllerBase
    {
        private readonly ILogger<ComprovanteController> logger;

        public ComprovanteController(ILogger<ComprovanteController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
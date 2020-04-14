using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/emissor/[controller]")]
    public class EmissorController : ControllerBase
    {
        private readonly ILogger<EmissorController> logger;

        public EmissorController(ILogger<EmissorController>  logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
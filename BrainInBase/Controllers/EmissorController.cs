using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainInBase.Contracts.Models.Emissor;
using BrainInBase.Contracts.Models.Registro;
using BrainInBaseApi.Context;
using BrainInBaseApi.Context.BrainEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmissorController : ControllerBase
    {
        private readonly ILogger<EmissorController> _logger;
        private readonly BrainInBaseContext _brainInBaseContext;

        public EmissorController(ILogger<EmissorController>  logger,BrainInBaseContext brainInBaseContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
        }

        [HttpPost]
        public async Task<IActionResult> GetEmissor([FromQuery] Guid emissorId)
        {            

            var emissor = _brainInBaseContext.Emissor.Where(u => u.Id == emissorId);

            var result = emissor.Select(e => new EmissorModel
            {
                Id = e.Id,
                Identificador = e.Identificador,
                Codigo = e.Codigo,
                Ativo = e.Ativo,
                CpfCpnj = e.CpfCpnj,
                RazaoSocial = e.RazaoSocial,
                NomeFantasia = e.NomeFantasia,
                Url = e.Url
            });

            return Ok(result);
        }
        
        [HttpPost("termo")]
        public async Task<IActionResult> FindEmissor([FromQuery] string termo)
        {
            var emissor = _brainInBaseContext.Emissor.Where(e => e.RazaoSocial.Contains(termo == null ? "" : termo)
                                                                 || e.NomeFantasia.Contains(termo));

            var result = emissor.Select(e => new EmissorModel
            {
                Id = e.Id,
                Identificador = e.Identificador,
                Codigo = e.Codigo,
                Ativo = e.Ativo,
                CpfCpnj = e.CpfCpnj,
                RazaoSocial = e.RazaoSocial,
                NomeFantasia = e.NomeFantasia,
                Url = e.Url
            });

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> PutEmissor([FromQuery] EmissorModel model)
        {
            var emissor = _brainInBaseContext.Emissor.Where(u => u.Id == model.Id);
            foreach (EmissorEntity update in emissor)
            {
                update.Ativo = model.Ativo;
                update.CpfCpnj = model.CpfCpnj;
                update.Identificador = model.Identificador;
                update.NomeFantasia = model.NomeFantasia;
                update.RazaoSocial = model.RazaoSocial;
                update.Url = model.Url;

                _brainInBaseContext.Emissor.Update(update);
                _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();
            }

            return Ok(model);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostEmissor([FromBody] EmissorModel model)
        {

            var result = new EmissorEntity
            {
               Ativo = model.Ativo,
               CpfCpnj = model.CpfCpnj,               
               Identificador = model.Identificador,               
               NomeFantasia = model.NomeFantasia,
               RazaoSocial = model.RazaoSocial,
               Url = model.Url
            };

            return Ok(result);
        }
    }
}
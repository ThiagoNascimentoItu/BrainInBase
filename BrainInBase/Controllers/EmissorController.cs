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
        public async Task<IActionResult> GetEmissor([FromQuery] string emissorId)
        {
            var id = emissorId.Split("-");

            var emissor = _brainInBaseContext.Emissor.Where(u => u.Padrao == Convert.ToInt32(id[0])
                                                              && u.Modificador == Convert.ToInt32(id[1])
                                                              && u.Codigo == Convert.ToInt32(id[2])
                                                              && u.Identificador == id[3]);

            var result = emissor.Select(e => new Emissor
            {
                Codigo = e.Padrao + "-" + e.Modificador + "-" + e.Codigo + "-" + e.Identificador,
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

            var result = emissor.Select(e => new Emissor
            {
                Codigo = e.Padrao + "-" + e.Modificador + "-" + e.Codigo + "-" + e.Identificador,
                Ativo = e.Ativo,
                CpfCpnj = e.CpfCpnj,
                RazaoSocial = e.RazaoSocial,
                NomeFantasia = e.NomeFantasia,
                Url = e.Url
            });

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> PutEmissor([FromQuery] Emissor model)
        {
            var id = model.Codigo.Split("-");

            var emissor = _brainInBaseContext.Emissor.Where(u => u.Padrao == Convert.ToInt32(id[0])
                                                              && u.Modificador == Convert.ToInt32(id[1])
                                                              && u.Codigo == Convert.ToInt32(id[2])
                                                              && u.Identificador == id[3]);
            foreach (EmissorEntity update in emissor)
            {
                update.Ativo = model.Ativo;
                update.CpfCpnj = model.CpfCpnj;
                update.NomeFantasia = model.NomeFantasia;
                update.RazaoSocial = model.RazaoSocial;
                update.Url = model.Url;

                _brainInBaseContext.Emissor.Update(update);
                _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();
            }

            return Ok(model);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostEmissor([FromBody] Emissor model)
        {
            var id = model.Codigo.Split("-");

            var result = new EmissorEntity
            {
               Ativo = model.Ativo,
               CpfCpnj = model.CpfCpnj,
               Codigo = Convert.ToInt32(id[2]),
               Identificador = id[3],
               Modificador = Convert.ToInt32(id[1]),
               Padrao = Convert.ToInt32(id[0]),
               NomeFantasia = model.NomeFantasia,
               RazaoSocial = model.RazaoSocial,
               Url = model.Url
            };

            return Ok(result);
        }
    }
}
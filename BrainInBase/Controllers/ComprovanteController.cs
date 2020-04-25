using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainInBase.Contracts.Models.Comprovante;
using BrainInBase.Query.Comprovante.Requests;
using BrainInBaseApi.Context;
using BrainInBaseApi.Context.BrainEntity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprovanteController : ControllerBase
    {
        private readonly ILogger<ComprovanteController> _logger;
        private readonly BrainInBaseContext _brainInBaseContext;
        private readonly IMediator _mediator;

        public ComprovanteController(ILogger<ComprovanteController> logger, BrainInBaseContext brainInBaseContext,
            IMediator mediator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<IActionResult> GetComprovante(GetComprovanteCommandRequest command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
            //var id = comprovanteId.Split("-");

            //var comprovante = _brainInBaseContext.Comprovantes.Where(r => r.Padrao == Convert.ToInt32(id[0]) && r.Modificador == Convert.ToInt32(id[1])
            //                                                  && r.Codigo == Convert.ToInt32(id[2]) && r.Identificador == id[3]);

            //var result = comprovante.Select(c =>  new ComprovanteModel
            //{
            //    Codigo = c.Padrao + "-" + c.Modificador + "-" + c.Codigo + "-" + c.Identificador,
            //    Descricao = c.Descricao,
            //    Arquivo = c.Arquivo,
            //    Tipo = c.Tipo,
            //    DataInclusao = c.DataInclusao
            //});

            //return Ok(result);
        }

        [HttpPost("termo")]
        public async Task<IActionResult> FindComprovantes(FindComprovanteCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
            //var comprovantes = _brainInBaseContext.Comprovantes.Where(c => c.Descricao.Contains(termo == null ? "" : termo));

            //var result = comprovantes.Select(c => new ComprovanteModel
            //{
            //    Codigo = c.Padrao + "-" + c.Modificador + "-" + c.Codigo + "-" + c.Identificador,
            //    Descricao = c.Descricao,
            //    Arquivo = c.Arquivo,
            //    Tipo = c.Tipo,
            //    DataInclusao = c.DataInclusao
            //});

            //return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> PutComprovante(ComprovanteCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);

            //var id = model.Codigo.Split("-");

            //var comprovante = _brainInBaseContext.Comprovantes.Where(r => r.Padrao == Convert.ToInt32(id[0]) && r.Modificador == Convert.ToInt32(id[1])
            //                                                    && r.Codigo == Convert.ToInt32(id[2]) && r.Identificador == id[3]);

            //foreach (ComprovantesEntity update in comprovante)
            //{
            //    update.Arquivo = model.Arquivo;
            //    update.DataInclusao = model.DataInclusao;
            //    update.Descricao = model.Descricao;
            //    update.Tipo = model.Tipo;

            //    _brainInBaseContext.Comprovantes.Update(update);
            //    _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();
            //}

            //return Ok(model);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostComprovantes(ComprovanteCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
            //var id = model.Codigo.Split("-");

            //var result = new ComprovantesEntity
            //{
            //    Arquivo = model.Arquivo,
            //    DataInclusao = model.DataInclusao,
            //    Descricao = model.Descricao,
            //    Tipo = model.Tipo,
            //    Padrao = Convert.ToInt32(id[0]),
            //    Modificador = Convert.ToInt32(id[1]),
            //    Codigo = Convert.ToInt32(id[2]),
            //    Identificador = id[3]
            //};

            //return Ok(result);

        }
    }
}
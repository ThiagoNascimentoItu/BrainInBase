using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainInBase.Contracts.Models.Registro;
using BrainInBaseApi.Context;
using BrainInBaseApi.Context.BrainEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : ControllerBase
    {
        private readonly ILogger<RegistroController> _logger;
        private readonly BrainInBaseContext _brainInBaseContext;

        public RegistroController(ILogger<RegistroController> logger, BrainInBaseContext brainInBaseContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
        }

        [HttpPost]
        public async Task<IActionResult> GetRegistros([FromQuery] Guid registroId)
        {
            var registro = _brainInBaseContext.Registros.Where(r => r.Id == registroId);

            var result = registro.Select(s => new RegistroModel
            {
                Codigo = s.Codigo,
                Descricao = s.Descricao,
                CargaHoraria = s.CargaHoraria,
                ChaveValidacao = s.ChaveValidacao,
                DataConclusao = s.DataConclusao,
                DataInicial = s.DataInicial,
                TipoRegistro = s.TipoRegistro,
                Url = s.Url,
                Validade = s.Validade,
                Arquivo = s.Arquivo
            });

            return Ok(result);
        }

        [HttpPost("termo")]
        public async Task<IActionResult> FindRegistros([FromQuery] string termo)
        {
            var registros = _brainInBaseContext.Registros.Where(r => r.Descricao.Contains(termo == null ? "" : termo));

            var result = registros.Select(s => new RegistroModel
            {
                Id = s.Id,
                Identificador = s.Identificador,
                Codigo = s.Codigo,
                Descricao = s.Descricao,
                CargaHoraria = s.CargaHoraria,
                ChaveValidacao = s.ChaveValidacao,
                DataConclusao = s.DataConclusao,
                DataInicial = s.DataInicial,
                TipoRegistro = s.TipoRegistro,
                Url = s.Url,
                Validade = s.Validade,
                Arquivo = s.Arquivo
            });

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> PutRegistros([FromQuery] RegistroModel model)
        {
            var registro = _brainInBaseContext.Registros.Where(r => r.Id == model.Id);

            foreach (RegistrosEntity update in registro)
            {
                update.Arquivo = model.Arquivo;
                update.Descricao = model.Descricao;
                update.DataConclusao = model.DataConclusao;
                update.CargaHoraria = model.CargaHoraria;
                update.DataInicial = model.DataInicial;
                update.ChaveValidacao = model.ChaveValidacao;
                update.TipoRegistro = model.TipoRegistro;
                update.Url = model.Url;
                update.Validade = model.Validade;
                update.Identificador = model.Identificador;

                _brainInBaseContext.Registros.Update(update);
                _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();
            }

            return Ok(model);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostRegistros([FromBody] RegistroModel model)
        {

            var result = new RegistrosEntity
            {
                Arquivo = model.Arquivo,
                CargaHoraria = model.CargaHoraria,
                ChaveValidacao = model.ChaveValidacao,
                DataConclusao = model.DataConclusao,
                DataInicial = model.DataInicial,
                Descricao = model.Descricao,
                TipoRegistro = model.TipoRegistro,
                Url = model.Url,
                Validade = model.Validade,
                Identificador = model.Identificador
            };

            _brainInBaseContext.Registros.AddAsync(result).GetAwaiter().GetResult();
            _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();

            return Ok(result);
        }
    }
}
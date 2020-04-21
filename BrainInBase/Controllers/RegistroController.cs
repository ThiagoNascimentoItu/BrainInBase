﻿using System;
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
        public async Task<IActionResult> GetRegistros([FromQuery] string registroId)
        {
            var id = registroId.Split("-");

            var registro = _brainInBaseContext.Registros.Where(r => r.Padrao == Convert.ToInt32(id[0]) && r.Modificador == Convert.ToInt32(id[1])
                                                                && r.Codigo == Convert.ToInt32(id[2]) && r.Identificador == id[3]);

            var result = registro.Select(s => new Registro
            {
                Codigo = s.Padrao + "-" + s.Modificador + "-" + s.Codigo + "-" + s.Identificador,
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

            var result = registros.Select(s => new Registro
            {
                Codigo = s.Padrao + "-" + s.Modificador + "-" + s.Codigo + "-" + s.Identificador,
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
        public async Task<IActionResult> PutRegistros([FromQuery] Registro model)
        {
            var id = model.Codigo.Split("-");

            var registro = _brainInBaseContext.Registros.Where(r => r.Padrao == Convert.ToInt32(id[0]) && r.Modificador == Convert.ToInt32(id[1])
                                                                && r.Codigo == Convert.ToInt32(id[2]) && r.Identificador == id[3]);

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

                _brainInBaseContext.Registros.Update(update);
                _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();
            }

            return Ok(model);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostRegistros([FromBody] Registro model)
        {
            var id = model.Codigo.Split("-");

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
                Padrao = Convert.ToInt32(id[0]),
                Modificador = Convert.ToInt32(id[1]),
                Codigo = Convert.ToInt32(id[2]),
                Identificador = id[3]
            };

            _brainInBaseContext.Registros.AddAsync(result).GetAwaiter().GetResult();
            _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();

            return Ok(result);
        }
    }
}
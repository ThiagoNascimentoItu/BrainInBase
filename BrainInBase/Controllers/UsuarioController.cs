using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainInBase.Contracts.Models.Usuario;
using BrainInBase.Query.Usuario.Requests;
using BrainInBaseApi.Context;
using BrainInBaseApi.Context.BrainEntity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BrainInBaseApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly BrainInBaseContext _brainInBaseContext;
        private readonly IMediator _mediator;

        public UsuarioController(ILogger<UsuarioController> logger, BrainInBaseContext brainInBaseContext, IMediator mediator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<IActionResult> GetUsuarioByCodigo(GetUsuarioCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost("termo")]
        public async Task<IActionResult> FindUsuarios(FindUsuarioCommandRequest command)
        {

            var response = await _mediator.Send(command);
            return Ok(response);

            //var usuarios = _brainInBaseContext.Usuarios.Where(u => u.Nome.Contains(termo == null ? "" : termo)
            //                        || u.Email.Contains(termo) && u.Ativo == true);

            //var result = usuarios.Select(r => new UsuarioModel
            //{
            //    Codigo = r.Padrao + "-" + r.Modificador + "-" + r.Codigo + "-" + r.Identificador,
            //    Nome = r.Nome,
            //    Sobrenome = r.Sobrenome,
            //    Email = r.Email,
            //    DataNascimento = r.DataNascimento.Date,
            //    Telefone = r.Telefone,
            //    Ativo = r.Ativo
            //});
            //return Ok(result);

        }

        [HttpPost("update")]
        public async Task<IActionResult> PutUsuario(UsuarioCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
            //var id = model.Codigo.Split("-");

            //var usuario = _brainInBaseContext.Usuarios.Where(u => u.Padrao == Convert.ToInt32(id[0])
            //                                                  && u.Modificador == Convert.ToInt32(id[1])
            //                                                  && u.Codigo == Convert.ToInt32(id[2])
            //                                                  && u.Identificador == id[3]);

            //foreach (UsuariosEntity update in usuario)
            //{
            //    update.Nome = model.Nome;
            //    update.Sobrenome = model.Sobrenome;
            //    update.Email = model.Email;
            //    update.Telefone = model.Telefone;
            //    update.DataNascimento = model.DataNascimento;
            //    update.Ativo = model.Ativo;

            //    _brainInBaseContext.Usuarios.Update(update);
            //}

            //_brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();

            //return Ok(usuario);
        }
       
        [HttpPost("adicionar")]
        public async Task<IActionResult> PostUsuario(UsuarioCommandRequest command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
            //var id = model.Codigo.Split("-");

            //var result = new UsuariosEntity
            //{
            //    Nome = model.Nome,
            //    Sobrenome = model.Sobrenome,
            //    Email = model.Email,
            //    Padrao = Convert.ToInt32(id[0]),
            //    Modificador = Convert.ToInt32(id[1]),
            //    Identificador = id[3],
            //    DataNascimento = model.DataNascimento,
            //    Telefone = model.Telefone,
            //    Ativo = model.Ativo,
            //};

            //_brainInBaseContext.Usuarios.Add(result);
            //_brainInBaseContext.SaveChanges();
            //return Ok(result);
        }
    }
}
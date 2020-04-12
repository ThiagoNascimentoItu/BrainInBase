using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainInBaseApi.Context;
using BrainInBaseApi.Context.BrainEntity;
using BrainInBaseClass.Usuarios;
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

        public UsuarioController(ILogger<UsuarioController> logger, BrainInBaseContext brainInBaseContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
        }


        [HttpPost]
        public async Task<IActionResult> PostUsuario([FromBody] Usuario model)
        {

            var id = model.Codigo.Split("-");

            var result = new UsuariosEntity
            {
                Nome = model.Nome,
                Sobrenome = model.Sobrenome,
                Email = model.Email,
                Padrao = Convert.ToInt32(id[0]),
                Modificador = Convert.ToInt32(id[1]),
                Identificador = id[3],
                DataNascimento = model.DataNascimento,
                Telefone = model.Telefone,
                Ativo = model.Ativo,
            };

            _brainInBaseContext.Usuarios.Add(result);
            _brainInBaseContext.SaveChanges();
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutUsuario([FromQuery] Usuario model)
        {
            var id = model.Codigo.Split("-");

            var usuarios = _brainInBaseContext.Usuarios.Where(u => u.Padrao == Convert.ToInt32(id[0])
                                                              && u.Modificador == Convert.ToInt32(id[1])
                                                              && u.Codigo == Convert.ToInt32(id[2])
                                                              && u.Identificador == id[3]);


            foreach (UsuariosEntity update in usuarios)
            {
                update.Nome = model.Nome;
                update.Sobrenome = model.Sobrenome;
                update.Email = model.Email;
                update.Telefone = model.Telefone;
                update.DataNascimento = model.DataNascimento;
                update.Ativo = model.Ativo;

                _brainInBaseContext.Usuarios.Update(update);
            }

            _brainInBaseContext.SaveChangesAsync().GetAwaiter().GetResult();

            return Ok(usuarios);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuariosByCodigo([FromQuery]UsuarioFiltro filtro)
        {
            var id = filtro.Codigo.Split("-");

            var result = from r in _brainInBaseContext.Usuarios
                         where r.Padrao == Convert.ToInt32(id[0]) && r.Modificador == Convert.ToInt32(id[1])
                               && r.Codigo == Convert.ToInt32(id[2]) && r.Identificador == id[3]
                         select new Usuario
                         {
                             Codigo = r.Padrao + "-" + r.Modificador + "-" + r.Codigo + "-" + r.Identificador,
                             Nome = r.Nome,
                             Sobrenome = r.Sobrenome,
                             Email = r.Email,
                             DataNascimento = r.DataNascimento.Date,
                             Telefone = r.Telefone,
                             Ativo = r.Ativo
                         };

            return Ok(result);
        }
        [HttpGet("termo")]
        public async Task<IActionResult> FindUsuarios([FromQuery] UsuarioFiltro filtro)
        {

            var usuario = _brainInBaseContext.Usuarios;

            var ResultTermo = usuario.Where(u => u.Nome.Contains(filtro.Termo == null ? "" : filtro.Termo)
                                    || u.Email.Contains(filtro.Termo) && u.Ativo == true);

            return Ok(ResultTermo);

        }


    }
}
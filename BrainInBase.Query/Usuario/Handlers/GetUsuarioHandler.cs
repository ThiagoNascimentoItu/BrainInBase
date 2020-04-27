using BrainInBase.Contracts.Models.Usuario;
using BrainInBase.Query.Context.BrainEntity;
using BrainInBase.Query.Usuario.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrainInBase.Query.Usuario.Handlers
{
    public class GetUsuarioHandler
    {
        private readonly BrainInBaseContext _brainInBaseContext;

        public GetUsuarioHandler(BrainInBaseContext brainInBaseContext) {
            _brainInBaseContext = brainInBaseContext ?? throw new ArgumentNullException(nameof(brainInBaseContext));
        }

        public Task<UsuarioResult> Handle(GetUsuarioCommandRequest request, CancellationToken cancellationToken)
        {
            IQueryable<UsuariosEntity> usuarioQuery = _brainInBaseContext.Usuarios;

            if (!String.IsNullOrEmpty(request.Id.ToString()))
                usuarioQuery = usuarioQuery.Where(u => u.Id == request.Id);

            var result = usuarioQuery.Select(r => new UsuarioResult
            {
                Id = r.Id,
                Nome = r.Nome,
                Sobrenome = r.Sobrenome,
                Email = r.Email,
                DataNascimento = r.DataNascimento.Date,
                Telefone = r.Telefone,
                Ativo = r.Ativo
            });

            return Task.FromResult(result);
        }
    }
}

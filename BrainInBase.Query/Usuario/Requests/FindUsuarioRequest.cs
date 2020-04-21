using BrainInBase.Contracts.Models.Usuario.Filter;
using BrainInBase.Query.Usuario.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Usuario.Requests
{
    public class FindUsuarioRequest: UsuarioFilter, IRequest<List<FindUsuarioHandler>>
    {
    }
}

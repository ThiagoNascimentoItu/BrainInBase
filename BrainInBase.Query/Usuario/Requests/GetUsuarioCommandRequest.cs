using BrainInBase.Contracts.Models.Usuario.Filter;
using BrainInBase.Query.Usuario.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Usuario.Requests
{
    public class GetUsuarioCommandRequest: UsuarioFilter, IRequest<GetUsuarioHandler>
    {
    }
}

using BrainInBase.Contracts.Models.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Usuario.Requests
{
    public class UsuarioCommandRequest: UsuarioModel, IRequest<UsuarioCommandRequest>
    {   
    }
}

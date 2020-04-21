using BrainInBase.Contracts.Models.Emissor;
using BrainInBase.Query.Emissor.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Emissor.Requests
{
   public class EmissorCommandRequest: EmissorModel, IRequest<EmissorCommandHandler>
    {
    }
}

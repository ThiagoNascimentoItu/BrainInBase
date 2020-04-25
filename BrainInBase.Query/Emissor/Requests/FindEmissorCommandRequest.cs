using BrainInBase.Contracts.Models.Emissor.Filter;
using BrainInBase.Query.Emissor.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Emissor.Requests
{
    public class FindEmissorCommandRequest:EmissorFilter, IRequest<List<FindEmissorHandler>>
    {
    }
}

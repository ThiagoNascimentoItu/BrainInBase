using BrainInBase.Contracts.Models.Registro.Filter;
using BrainInBase.Query.Registro.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Registro.Requests
{
    public class FindRegistroRequest : RegistroFilter, IRequest<List<FindRegistroHandler>>
    {
    }
}

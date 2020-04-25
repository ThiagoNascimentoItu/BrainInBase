using BrainInBase.Contracts.Models.Comprovante.Filter;
using BrainInBase.Query.Comprovante.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Comprovante.Requests
{
    public class FindComprovanteCommandRequest:ComprovanteFilter,IRequest<List<FindComprovanteHandler>>
    {
    }
}

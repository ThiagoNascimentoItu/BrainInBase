using BrainInBase.Contracts.Models.Comprovante;
using BrainInBase.Query.Comprovante.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Comprovante.Requests
{
    public class ComprovanteCommandRequest: ComprovanteModel,IRequest<ComprovanteCommandHandler>
    {
     
    }
}

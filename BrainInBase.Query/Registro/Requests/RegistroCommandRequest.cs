using BrainInBase.Contracts.Models.Usuario;
using BrainInBase.Query.Registro.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Registro.Requests
{
    public class RegistroCommandRequest:UsuarioModel, IRequest<RegistroCommandHundler>
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal CargaHoraria { get; set; }
        public string ChaveValidacao { get; set; }
        public string Url { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime DataConclusao { get; set; }
        public int Validade { get; set; }
        public string TipoRegistro { get; set; }
        public byte[] Arquivo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Comprovante
{
    public class ComprovanteModel
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Identificador { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Tipo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}

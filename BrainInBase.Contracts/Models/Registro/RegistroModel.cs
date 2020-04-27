using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Registro
{
    public class RegistroModel
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Identificador { get; set; }
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

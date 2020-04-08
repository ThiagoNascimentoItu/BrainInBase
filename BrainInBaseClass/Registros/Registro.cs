using BrainInBaseClass.Instituicaos;
using BrainInBaseClass.Registros;
using System;

namespace BrainInBaseClass.Registro
{
   public class Registro
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
        public Arquivo Arquivo { get; set; }
        public Instituicao Instituicao{ get; set; }

    }
}

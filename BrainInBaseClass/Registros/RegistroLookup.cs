using System;
using System.Collections.Generic;
using System.Text;


namespace BrainInBaseClass.Registros
{
    public class RegistroLookup
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusao { get; set; }
        public decimal CargaHoraria { get; set; }

    }
}

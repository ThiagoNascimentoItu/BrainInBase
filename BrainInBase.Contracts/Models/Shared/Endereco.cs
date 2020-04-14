using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Shared
{
    public class Endereco
    {
        public string Codigo { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string TipoLougradouro { get; set; }
        public string Cep { get; set; }
    }
}

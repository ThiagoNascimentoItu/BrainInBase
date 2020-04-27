using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Emissor
{
    public class EmissorModel
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Identificador { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCpnj { get; set; }
        public bool Ativo { get; set; }
        public string Url { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Query.Emissor.Handlers
{
    public class EmissorCommandHandler
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCpnj { get; set; }
        public bool Ativo { get; set; }
        public string Url { get; set; }
    }
}

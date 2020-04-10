using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBaseClass.Instituicoes
{
    public class Instituicao
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCpnj { get; set; }
        public bool Ativo { get; set; }
        public string Url { get; set; }
    }
}

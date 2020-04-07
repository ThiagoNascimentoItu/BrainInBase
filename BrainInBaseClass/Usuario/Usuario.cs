using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBaseClass.Usuario
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        
    }
}

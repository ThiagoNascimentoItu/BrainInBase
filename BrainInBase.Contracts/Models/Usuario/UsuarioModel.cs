using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Usuario
{
    public class UsuarioModel
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}

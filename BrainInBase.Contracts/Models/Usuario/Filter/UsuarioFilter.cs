﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BrainInBase.Contracts.Models.Usuario.Filter
{
    public class UsuarioFilter
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Termo { get; set; }

    }
}

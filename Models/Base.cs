﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public abstract class Base
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }
    }
}

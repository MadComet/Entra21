﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_OO.Heranca
{
    class Empresa : DadosBancarios
    {
        public List<Funcionario> Funcionarios { get; set; }

    }
}
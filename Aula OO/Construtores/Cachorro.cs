﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_OO
{
    class Cachorro : Animais
    {
        public string nomeDoDono;

        public Cachorro(string nome, string nomeDoDono, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.nomeDoDono = nomeDoDono;
        }
    }
}